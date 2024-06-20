using System;

namespace Gtt.Labels.UI.WebApi.Controllers.Etis
{
    public class MaterialReturnLabelRequest
    {
        public string PointOfUse { get; set; }

        public string Line { get; set; }

        public string EtiNo { get; set; }

        public string ComponentNo { get; set; }

        public string EmployeeName { get; set; }

        public string LineCode { get; set; }

        public string PartNo { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}