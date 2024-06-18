using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Gtt.Labels.UI.WebService.Labels.IndividualLabels
{
    public partial class FramelessPatentLabel : XtraReport
    {
        private readonly char RS = Convert.ToChar(30);
        private readonly char GS = Convert.ToChar(29);
        private readonly char EOT = Convert.ToChar(4);

        public FramelessPatentLabel(string productType, long transmissionID, string revision, string serialNo, int julianDay, int year, string externalReference, string station, string ratio, string lineCode, string Patente1, string Patente2, string Patente3, string Patente4, string Patente5, string Patente6, string Patente7,string Patente8)
        {
            var errors = new List<string>();
            if (transmissionID == 0) errors.Add("El número de transmisión no fue especificado.");
            if (year == 0) errors.Add("El año no fue especificado.");
            if (julianDay == 0) errors.Add("La fecha juliana no fue especificada.");
            //if (string.Compare("U5", lineCode, true) != 0)
            //{
            //    errors.Add("La etiqueta es exlusiva para Motores.");
            //}
            if (string.IsNullOrWhiteSpace(externalReference)) errors.Add("La referencia externa no fue especificada.");
            if (string.IsNullOrWhiteSpace(ratio)) errors.Add("La razón (ratio) no fue especificada.");
            if (string.IsNullOrWhiteSpace(lineCode)) errors.Add("El código de línea fue especificado.");
            if (string.IsNullOrWhiteSpace(revision)) errors.Add("La revisión no fue especificada.");
            if (string.IsNullOrWhiteSpace(serialNo)) errors.Add("El número de serie fue especificado.");
            if (errors.Count > 0)
            {
                throw new InvalidOperationException(errors.Aggregate((a, b) => $"{a}\n{b}"));
            }

            InitializeComponent();
            this.BeforePrint += (s, e) =>
            {
                var series = serialNo.ToUpper().Split('-');
                if (series.Length > 0 && series[0].StartsWith("GT"))
                {
                    series[0] = series[0].Replace("GT", "");
                }
                txtRefExt.Text = $"(P) {externalReference}";
                //txtInternalID.Text = $"(S) {productType.ToUpper()}{transmissionID}";
                txtInternalID.Text = $"(S) WB{transmissionID}";
                barCode.Text = $"[)>{RS}06{GS}SWB{transmissionID}{GS}P{externalReference}{GS}ZGT{GS}1T{series[0].Trim()}{GS}2T{revision}{GS}3T{julianDay}{year.ToString().Substring(2)}{RS}{EOT}";
                txtSerial.Text = $"{series[0].Trim()}{ratio}{julianDay}{year.ToString()[3]}{lineCode}{station}";
                //////Nuevo agregado para Frameless 
                if (string.IsNullOrWhiteSpace(Patente1) || Patente1 == "N/A") txtPatent_001.Text = $" ";
                txtPatent_001.Text = $"{Patente1}";
                if (string.IsNullOrWhiteSpace(Patente2) || Patente2 == "N/A") txtPatent_002.Text = $" ";
                txtPatent_002.Text = $"{Patente2}";
                if (string.IsNullOrWhiteSpace(Patente3) || Patente3 == "N/A") txtPatent_002.Text = $" ";
                txtPatent_003.Text = $"{Patente3}";
                if (string.IsNullOrWhiteSpace(Patente4) || Patente4 == "N/A") txtPatent_004.Text = $" ";
                txtPatent_004.Text = $"{Patente4}";
                if (string.IsNullOrWhiteSpace(Patente5) || Patente5 == "N/A") txtPatent_005.Text = $" ";
                txtPatent_005.Text = $"{Patente5}";
                if (string.IsNullOrWhiteSpace(Patente6) || Patente6 == "N/A") txtPatent_006.Text = $" ";
                txtPatent_006.Text = $"{Patente6}";
                if (string.IsNullOrWhiteSpace(Patente7) || Patente7 == "N/A") txtPatent_007.Text = $" ";
                txtPatent_007.Text = $"{Patente7}";
                if (string.IsNullOrWhiteSpace(Patente8) || Patente8 == "N/A") txtPatent_008.Text = $" ";
                txtPatent_008.Text = $"{Patente8}";
            };
        }
    }
}