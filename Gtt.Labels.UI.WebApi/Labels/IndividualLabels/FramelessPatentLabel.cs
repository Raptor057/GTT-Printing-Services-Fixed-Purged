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

        public FramelessPatentLabel(string productType, long transmissionID, string revision, string serialNo, int julianDay, int year, string externalReference, string station, string ratio, string lineCode, string Patent1, string Patent2, string Patent3, string Patent4, string Patent5, string Patent6, string Patent7,string Patent8)
        {
            var errors = new List<string>();
            if (transmissionID == 0) errors.Add("El número de transmisión no fue especificado.");
            if (year == 0) errors.Add("El año no fue especificado.");
            if (julianDay == 0) errors.Add("La fecha juliana no fue especificada.");
            if (string.Compare("U5", lineCode, true) != 0)
            {
                errors.Add("La etiqueta es exlusiva para Motores.");
            }
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
                ////Nuevo agregado para Frameless 
                txtPatent_001.Text = $"{Patent1}";
                txtPatent_002.Text = $"{Patent2}";
                txtPatent_003.Text = $"{Patent3}";
                txtPatent_004.Text = $"{Patent4}";
                txtPatent_005.Text = $"{Patent5}";
                txtPatent_006.Text = $"{Patent6}";
                txtPatent_007.Text = $"{Patent7}";
                txtPatent_008.Text = $"{Patent8}";
            };
        }
    }
}