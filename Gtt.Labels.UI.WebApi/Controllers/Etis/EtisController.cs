using DevExpress.XtraReports.UI;
using Microsoft.Extensions.Configuration;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Gtt.Labels.UI.WebApi.Controllers.Etis
{
    [RoutePrefix("api/etis")]
    public class EtisController : ApiController
    {
        private readonly IConfiguration _configuration;

        public EtisController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost, Route("returnlabels")]
        public async Task<dynamic> MaterialReturn([FromBody] MaterialReturnLabelRequest request)
        {
            try
            {
                var linePrinterSection = _configuration.GetSection($"MaterialReturns:Printers:{request.Line.ToUpper()}");
                var printerName = linePrinterSection.GetSection("Route").Value;
                var description = linePrinterSection.GetSection("description").Value;
                if (!string.IsNullOrWhiteSpace(printerName))
                {
                    await Task.Run(() => PrintMaterialReturnLabel(printerName, request.EtiNo, request.ComponentNo, request.EmployeeName, request.LineCode, request.PartNo, request.TimeStamp, request.PointOfUse))
                        .ConfigureAwait(false);
                    return Request.CreateResponse(HttpStatusCode.OK, $"Tomar la etiqueta de la impresora \"{description}\".");
                }
                return Request.CreateResponse(HttpStatusCode.NotFound, $"No se encontró información de impresora para la línea \"{request.Line}\".");
            }
            catch (Exception ex)
            {
                return ex;
            }
        }

        private void PrintMaterialReturnLabel(string printerName, string etiNo, string componentNo, string employeeName, string lineCode, string partNo, DateTime timeStamp, string pointOfUse)
        {
            using (var returnLabel = new Labels.MaterialReturnLabel(etiNo, componentNo, employeeName, lineCode, partNo, timeStamp, pointOfUse))
            {
                using (ReportPrintTool printTool = new ReportPrintTool(returnLabel))
                {
                    printTool.Report.CreateDocument();
                    printTool.PrintingSystem.ShowPrintStatusDialog = false;
                    printTool.Print(printerName);
                }
            }
        }
    }
}