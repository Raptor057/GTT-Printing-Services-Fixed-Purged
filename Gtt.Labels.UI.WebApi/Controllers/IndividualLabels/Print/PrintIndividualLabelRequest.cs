namespace Gtt.Labels.UI.WebApi.Controllers.IndividualLabels.Print
{
    public class PrintIndividualLabelRequest
    {
        public long FinishGoodID { get; set; }

        public bool IsDoubleLid { get; set; }

        public string ExternalReference { get; set; }

        public string Station { get; set; }


        public int JulianDay { get; set; }


        public string Revision { get; set; }

        public string LineCode { get; set; }

        public string Ratio { get; set; }

        public string SerialNo { get; set; }

        public int Year { get; set; }

        #region Nuevo agregado para Frameless 
        //Nuevo agregado para Frameless
        public string Patent1 { get; set; }
        public string Patent2 { get; set; }
        public string Patent3 { get; set; }
        public string Patent4 { get; set; }
        public string Patent5 { get; set; }
        public string Patent6 { get; set; }
        public string Patent7 { get; set; }
        public string Patent8 { get; set; }
        #endregion
    }
}