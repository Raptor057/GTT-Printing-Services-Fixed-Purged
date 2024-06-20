using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Gtt.Labels.UI.WebService.Labels.IndividualLabels
{
    public partial class WalkBehind1 : XtraReport
    {
        public WalkBehind1(long transmissionID, string serialNo, int julianDay, int year, string externalReference, string ratio, string lineCode)
        {
            var errors = new List<string>();
            if (transmissionID == 0) errors.Add("El número de transmisión no fue especificado.");
            if (year == 0) errors.Add("El año no fue especificado.");
            if (julianDay == 0) errors.Add("La fecha juliana no fue especificada.");
            if (string.IsNullOrWhiteSpace(externalReference)) errors.Add("La referencia externa no fue especificada.");
            if (string.IsNullOrWhiteSpace(ratio)) errors.Add("La razón (ratio) no fue especificada.");
            if (string.IsNullOrWhiteSpace(lineCode)) errors.Add("El código de línea fue especificado.");
            if (errors.Count > 0)
            {
                throw new InvalidOperationException(errors.Aggregate((a, b) => $"{a}\n{b}"));
            }

            InitializeComponent();
            this.BeforePrint += (s, e) =>
            {
                string[] series = serialNo.Split('-');
                txtRefExt.Text = $"(P) {externalReference}";
                txtInternalID.Text = $"(S) WB{transmissionID}";
                //barCode.Text = $"{"[)>"}{RS}{"06"}{GS}{"S"}{"WB"}{tm.id}{GS}{"P"}{ref_ext.TrimEnd()}{GS}{"ZGT"}{GS}{"1T"}{series[0].Trim()}{GS}{"2T"}{tm.rev}{GS}{"3T"}{tm.julian_day}{tm.year.ToString().Right(2)}{RS}{EOT}";
                txtSerial.Text = $"{series[0].Trim()}{ratio}{julianDay}{year.ToString()[3]}{lineCode}";
            };
        }
    }
}