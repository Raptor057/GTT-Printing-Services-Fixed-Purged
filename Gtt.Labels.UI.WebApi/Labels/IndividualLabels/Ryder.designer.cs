namespace Gtt.Labels.UI.WebService.Labels.IndividualLabels
{
    partial class Ryder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ryder));
            DevExpress.XtraPrinting.BarCode.DataMatrixGS1Generator dataMatrixGS1Generator1 = new DevExpress.XtraPrinting.BarCode.DataMatrixGS1Generator();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrPanel1 = new DevExpress.XtraReports.UI.XRPanel();
            this.barCode = new DevExpress.XtraReports.UI.XRBarCode();
            this.txtRefExt = new DevExpress.XtraReports.UI.XRLabel();
            this.txtInternalID = new DevExpress.XtraReports.UI.XRLabel();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox1,
            this.xrPanel1});
            this.TopMargin.HeightF = 83.34004F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox1.Image")));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(9.41661F, 15.74211F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(39.12506F, 39.2124F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // xrPanel1
            // 
            this.xrPanel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.barCode,
            this.txtRefExt,
            this.txtInternalID});
            this.xrPanel1.LocationFloat = new DevExpress.Utils.PointFloat(48.54167F, 15.74211F);
            this.xrPanel1.Name = "xrPanel1";
            this.xrPanel1.SizeF = new System.Drawing.SizeF(136.7672F, 46.13287F);
            // 
            // barCode
            // 
            this.barCode.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.barCode.AutoModule = true;
            this.barCode.Font = new System.Drawing.Font("Times New Roman", 2F);
            this.barCode.LocationFloat = new DevExpress.Utils.PointFloat(86.77983F, 0F);
            this.barCode.Module = 1F;
            this.barCode.Name = "barCode";
            this.barCode.Padding = new DevExpress.XtraPrinting.PaddingInfo(1, 1, 0, 0, 100F);
            this.barCode.ShowText = false;
            this.barCode.SizeF = new System.Drawing.SizeF(49.98737F, 46.13287F);
            this.barCode.StylePriority.UseFont = false;
            this.barCode.StylePriority.UsePadding = false;
            dataMatrixGS1Generator1.MatrixSize = DevExpress.XtraPrinting.BarCode.DataMatrixSize.Matrix26x26;
            this.barCode.Symbology = dataMatrixGS1Generator1;
            this.barCode.Text = "1234567891212321312312312313213213213123213123123213123213213";
            // 
            // txtRefExt
            // 
            this.txtRefExt.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.txtRefExt.CanGrow = false;
            this.txtRefExt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRefExt.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.txtRefExt.Name = "txtRefExt";
            this.txtRefExt.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtRefExt.SizeF = new System.Drawing.SizeF(86.77985F, 16.99999F);
            this.txtRefExt.StylePriority.UseBorders = false;
            this.txtRefExt.StylePriority.UseFont = false;
            this.txtRefExt.StylePriority.UseTextAlignment = false;
            this.txtRefExt.Text = "(P) 123456-10";
            this.txtRefExt.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.txtRefExt.WordWrap = false;
            // 
            // txtInternalID
            // 
            this.txtInternalID.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.txtInternalID.CanGrow = false;
            this.txtInternalID.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInternalID.LocationFloat = new DevExpress.Utils.PointFloat(0F, 29.13287F);
            this.txtInternalID.Name = "txtInternalID";
            this.txtInternalID.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtInternalID.SizeF = new System.Drawing.SizeF(86.77985F, 17F);
            this.txtInternalID.StylePriority.UseBorders = false;
            this.txtInternalID.StylePriority.UseFont = false;
            this.txtInternalID.StylePriority.UseTextAlignment = false;
            this.txtInternalID.Text = "(S) WB000000";
            this.txtInternalID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.txtInternalID.WordWrap = false;
            // 
            // Detail
            // 
            this.Detail.HeightF = 99F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 100F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Ryder
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.Margins = new System.Drawing.Printing.Margins(2, 3, 83, 100);
            this.PageHeight = 295;
            this.PageWidth = 276;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.SnapGridSize = 9.84252F;
            this.Version = "17.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.XRBarCode barCode;
        private DevExpress.XtraReports.UI.XRPanel xrPanel1;
        private DevExpress.XtraReports.UI.XRLabel txtRefExt;
        private DevExpress.XtraReports.UI.XRLabel txtInternalID;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
    }
}
