using DevExpress.XtraReports.UI;
using Gtt.Labels.UI.WebService.Labels.IndividualLabels;
using Microsoft.Extensions.Configuration;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Gtt.Labels.UI.WebApi.Controllers.IndividualLabels.Print
{
    [RoutePrefix("api")]
    public class PrintIndividualLabelsController : ApiController
    {
        private readonly IConfiguration _configuration;

        public PrintIndividualLabelsController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        private static bool IsWalkBehind(string productType)
        {
            return string.Compare(productType, "WB", true) == 0;
        }

        private static bool IsRider(string productType)
        {
            return string.Compare(productType, "RD", true) == 0;
        }

        private static bool IsEZ(string productType)
        {
            return string.Compare(productType, "EZ", true) == 0;
        }

        private static bool IsRE(string productType)
        {
            return string.Compare(productType, "RE", true) == 0;
        }

        private static bool IsRS(string productType)
        {
            return string.Compare(productType, "RS", true) == 0;
        }

        private static bool IsRT(string productType)
        {
            return string.Compare(productType, "RT", true) == 0;
        }

        //03 / 23 / 2023 RA: Nuevo agregado para Frameless 
        private static bool IsFL(string productType)
        {
            return string.Compare(productType, "ME FL", true) == 0;
        }
        //03 / 29 / 2023 RA: Nuevo agregado para Motores
        private static bool IsMT(string productType)
        {
            return string.Compare(productType, "MT", true) == 0;
        }

        [HttpPost, Route("productlines/{line}/individuallabels/{productType}")]
        public async Task<dynamic> Execute(string line, string productType, [FromBody] PrintIndividualLabelRequest request)
        {
            if (request == null)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "El cuerpo de la petición no es válido.");
            }

            var linePrinterSection = _configuration.GetSection($"IndividualLabels:Printers:{line.ToUpper()}");
            var printerRoute = linePrinterSection.GetSection("Route").Value;
            var description = linePrinterSection.GetSection("description").Value;
            if (string.IsNullOrEmpty(printerRoute))
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, $"No se encontró información de impresora para la línea \"{line}\".");
            }

            try
            {
                XtraReport labelReport;
                //03 / 29 / 2023 RA: Nuevo agregado IsMT
                if (IsWalkBehind(productType) || IsMT(productType))
                {
                    if (request.IsDoubleLid)
                    {
                        labelReport = new WalkBehind1(request.FinishGoodID, request.SerialNo, request.JulianDay, request.Year, request.ExternalReference, request.Ratio, request.LineCode);
                    }
                    else
                    {
                        labelReport = new WalkBehind(request.FinishGoodID, request.Revision, request.SerialNo, request.JulianDay, request.Year, request.ExternalReference, request.Station, request.Ratio, request.LineCode, request.Origen);
                    }
                }
                else if (IsRider(productType))
                {
                    labelReport = new Ryder(request.FinishGoodID, request.Revision, request.SerialNo, request.JulianDay, request.Year, request.ExternalReference);
                }
                else if (IsEZ(productType) || IsRE(productType) || IsRS(productType))
                {
                    //Se comento esto para redireccionar las etis originales de EZ a otra nueva ETI que contenga las patentes.

                    //    labelReport = new EZIndividualLabel(productType, request.FinishGoodID, request.Revision, request.SerialNo, request.JulianDay, request.Year, request.ExternalReference, request.Station, request.Ratio, request.LineCode, request.Origen);
                        labelReport = new EZIndividualLabel01(productType, request.FinishGoodID, request.Revision, request.SerialNo, request.JulianDay, request.Year, request.ExternalReference, request.Station, request.Ratio, request.LineCode, request.Origen, 
                            request.Patente1, request.Patente2, request.Patente3, request.Patente4, request.Patente5, request.Patente6,
                        request.Patente7, request.Patente8);
                }
                else if (IsRT(productType))
                {
                    //Agregado el dia 04/04/2024 
                    //Solicitado por Yadira Gracia y Fabien Guerrier
                    labelReport = new WalkBehind2(request.FinishGoodID, request.Revision, request.SerialNo, request.JulianDay, request.Year, request.ExternalReference);
                }
                //   03/23/2023 - RA: Se agrego para poner las patentes en las etiquetas, Nuevo agregado para Frameless 
                else if (IsFL(productType))
                {
                    labelReport = new FramelessPatentLabel(productType, request.FinishGoodID, request.Revision, request.SerialNo, request.JulianDay, request.Year, request.ExternalReference, 
                        request.Station, request.Ratio, request.LineCode, request.Patente1, request.Patente2, request.Patente3, request.Patente4, request.Patente5, request.Patente6, 
                        request.Patente7, request.Patente8);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, $"El tipo de producto \"{productType}\" no es válido.");
                }

                labelReport.ShowPrintMarginsWarning = false;
                labelReport.ShowPrintStatusDialog = false;

                await Task.Run(delegate
                {
                    using (var reportPrintTool = new ReportPrintTool(labelReport))
                    {
                        reportPrintTool.Report.CreateDocument();
                        reportPrintTool.PrintingSystem.ShowPrintStatusDialog = false;
                        reportPrintTool.Print(printerRoute);
                    }
                }).ConfigureAwait(false);

                labelReport.Dispose();

                if (request.IsDoubleLid)
                {
                    await Task.Run(delegate
                    {
                        using (var report = new WalkBehind2(request.FinishGoodID, request.Revision, request.SerialNo, request.JulianDay, request.Year, request.ExternalReference)
                        {
                            ShowPrintMarginsWarning = false,
                            ShowPrintStatusDialog = false
                        })
                        {
                            using (var reportPrintTool = new ReportPrintTool(report))
                            {
                                reportPrintTool.Report.CreateDocument();
                                reportPrintTool.PrintingSystem.ShowPrintStatusDialog = false;
                                reportPrintTool.Print(printerRoute);
                            }
                        }
                    }).ConfigureAwait(false);
                }

                return Request.CreateResponse(HttpStatusCode.OK, $"Tomar la etiqueta de la impresora \"{description}\".");
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost, Route("productlines/{line}/individuallabels/error")]
        public async Task<dynamic> Err(string line, [FromBody] string request)
        {
            if (request == null)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "El cuerpo de la petición no es válido.");
            }

            var linePrinterSection = _configuration.GetSection($"IndividualLabels:Printers:{line.ToUpper()}");
            var printerRoute = linePrinterSection.GetSection("Route").Value;
            var description = linePrinterSection.GetSection("description").Value;
            if (string.IsNullOrEmpty(printerRoute))
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, $"No se encontró información de impresora para la línea \"{line}\".");
            }

            try
            {
                await Task.Run(delegate
                {
                    using (var report = new IndividualLabelError(request)
                    {
                        ShowPrintMarginsWarning = false,
                        ShowPrintStatusDialog = false
                    })
                    {
                        using (var reportPrintTool = new ReportPrintTool(report))
                        {
                            reportPrintTool.Report.CreateDocument();
                            reportPrintTool.PrintingSystem.ShowPrintStatusDialog = false;
                            reportPrintTool.Print(printerRoute);
                        }
                    }
                }).ConfigureAwait(false);

                return Request.CreateResponse(HttpStatusCode.OK, $"Tomar la etiqueta de la impresora \"{description}\".");
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}