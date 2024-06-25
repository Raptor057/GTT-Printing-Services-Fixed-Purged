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

        //   03/22/2023 - RA: Se agrego para poner el Origen de las etiquetas
        public string Origen { get; set; }

        #region Nuevo agregado para Frameless 
        //  03/22/2023 - RA: Nuevo agregado para Frameless
        public string Patente1 { get; set; }
        public string Patente2 { get; set; }
        public string Patente3 { get; set; }
        public string Patente4 { get; set; }
        public string Patente5 { get; set; }
        public string Patente6 { get; set; }
        public string Patente7 { get; set; }
        public string Patente8 { get; set; }
        #endregion
    }
}