using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Gtt.Labels.UI.WebService.Labels.IndividualLabels
{
    public partial class Ryder : XtraReport
    {
        private readonly char RS = Convert.ToChar(30);
        private readonly char GS = Convert.ToChar(29);
        private readonly char EOT = Convert.ToChar(4);

        public Ryder(long transmissionID, string revision, string serialNo, int julianDay, int year, string externalReference)
        {
            var errors = new List<string>();
            if (transmissionID == 0) errors.Add("El número de transmisión no fue especificado.");
            if (year == 0) errors.Add("El año no fue especificado.");
            if (julianDay == 0) errors.Add("La fecha juliana no fue especificada.");
            if (string.IsNullOrWhiteSpace(externalReference)) errors.Add("La referencia externa no fue especificada.");
            if (string.IsNullOrWhiteSpace(revision)) errors.Add("La revisión no fue especificada.");
            if (string.IsNullOrWhiteSpace(serialNo)) errors.Add("El número de serie fue especificado.");
            if (errors.Count > 0)
            {
                throw new InvalidOperationException(errors.Aggregate((a, b) => $"{a}\n{b}"));
            }

            InitializeComponent();
            this.BeforePrint += (s, e) =>
            {
                string[] series = serialNo.Split('-');
                txtRefExt.Text = $"(P) {externalReference.TrimEnd()}";
                txtInternalID.Text = $"(S) WB{transmissionID}";
                barCode.Text = $"[)>{RS}06{GS}SWB{transmissionID}{GS}P{externalReference.TrimEnd()}{GS}ZGT{GS}1T{series[0].Trim()}{GS}2T{revision}{GS}3T{julianDay}{year.ToString().Substring(2)}{RS}{EOT}";
            };
        }
    }
}