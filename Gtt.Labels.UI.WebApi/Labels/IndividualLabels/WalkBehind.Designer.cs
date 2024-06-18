namespace Gtt.Labels.UI.WebService.Labels.IndividualLabels
{
    partial class WalkBehind
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
            DevExpress.XtraPrinting.BarCode.DataMatrixGS1Generator dataMatrixGS1Generator1 = new DevExpress.XtraPrinting.BarCode.DataMatrixGS1Generator();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WalkBehind));
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.txtOrigen = new DevExpress.XtraReports.UI.XRLabel();
            this.barCode = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrPanel1 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.txtRefExt = new DevExpress.XtraReports.UI.XRLabel();
            this.txtInternalID = new DevExpress.XtraReports.UI.XRLabel();
            this.txtSerial = new DevExpress.XtraReports.UI.XRLabel();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.txtOrigen,
            this.barCode,
            this.xrPanel1});
            this.TopMargin.HeightF = 83.34004F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // txtOrigen
            // 
            this.txtOrigen.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.txtOrigen.CanGrow = false;
            this.txtOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 3.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrigen.LocationFloat = new DevExpress.Utils.PointFloat(11.00001F, 13.00517F);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtOrigen.SizeF = new System.Drawing.SizeF(57.49666F, 6.999996F);
            this.txtOrigen.StylePriority.UseBorders = false;
            this.txtOrigen.StylePriority.UseFont = false;
            this.txtOrigen.StylePriority.UseTextAlignment = false;
            this.txtOrigen.Text = "(O) GT-MEX";
            this.txtOrigen.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.txtOrigen.WordWrap = false;
            // 
            // barCode
            // 
            this.barCode.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.barCode.AutoModule = true;
            this.barCode.Font = new System.Drawing.Font("Times New Roman", 2F);
            this.barCode.LocationFloat = new DevExpress.Utils.PointFloat(68.49667F, 13F);
            this.barCode.Module = 1F;
            this.barCode.Name = "barCode";
            this.barCode.Padding = new DevExpress.XtraPrinting.PaddingInfo(1, 1, 0, 0, 100F);
            this.barCode.ShowText = false;
            this.barCode.SizeF = new System.Drawing.SizeF(77.28317F, 37.00519F);
            this.barCode.StylePriority.UseFont = false;
            this.barCode.StylePriority.UsePadding = false;
            dataMatrixGS1Generator1.MatrixSize = DevExpress.XtraPrinting.BarCode.DataMatrixSize.Matrix26x26;
            this.barCode.Symbology = dataMatrixGS1Generator1;
            this.barCode.Text = "1234567891212321312312312313213213213123213123123213123213213";
            // 
            // xrPanel1
            // 
            this.xrPanel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox1,
            this.txtRefExt,
            this.txtInternalID,
            this.txtSerial});
            this.xrPanel1.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 13F);
            this.xrPanel1.Name = "xrPanel1";
            this.xrPanel1.SizeF = new System.Drawing.SizeF(136.7672F, 46.13287F);
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox1.Image")));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(0.9999955F, 10F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(17.49665F, 17.00517F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // txtRefExt
            // 
            this.txtRefExt.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.txtRefExt.CanGrow = false;
            this.txtRefExt.Font = new System.Drawing.Font("Microsoft Sans Serif", 3.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRefExt.LocationFloat = new DevExpress.Utils.PointFloat(18.49666F, 7.005175F);
            this.txtRefExt.Multiline = true;
            this.txtRefExt.Name = "txtRefExt";
            this.txtRefExt.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtRefExt.SizeF = new System.Drawing.SizeF(40F, 9.999998F);
            this.txtRefExt.StylePriority.UseBorders = false;
            this.txtRefExt.StylePriority.UseFont = false;
            this.txtRefExt.StylePriority.UseTextAlignment = false;
            this.txtRefExt.Text = "(P)000000000";
            this.txtRefExt.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.txtRefExt.WordWrap = false;
            // 
            // txtInternalID
            // 
            this.txtInternalID.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.txtInternalID.CanGrow = false;
            this.txtInternalID.Font = new System.Drawing.Font("Microsoft Sans Serif", 3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInternalID.LocationFloat = new DevExpress.Utils.PointFloat(18.49665F, 17.00517F);
            this.txtInternalID.Name = "txtInternalID";
            this.txtInternalID.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtInternalID.SizeF = new System.Drawing.SizeF(40F, 10F);
            this.txtInternalID.StylePriority.UseBorders = false;
            this.txtInternalID.StylePriority.UseFont = false;
            this.txtInternalID.StylePriority.UseTextAlignment = false;
            this.txtInternalID.Text = "(S)WB123456789";
            this.txtInternalID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.txtInternalID.WordWrap = false;
            // 
            // txtSerial
            // 
            this.txtSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 3.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerial.LocationFloat = new DevExpress.Utils.PointFloat(0.9999955F, 27.00519F);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtSerial.SizeF = new System.Drawing.SizeF(57.49667F, 10F);
            this.txtSerial.StylePriority.UseFont = false;
            this.txtSerial.StylePriority.UseTextAlignment = false;
            this.txtSerial.Text = "GT84737R4.5230LI";
            this.txtSerial.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
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
            // WalkBehind
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
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
        private DevExpress.XtraReports.UI.XRLabel txtRefExt;
        private DevExpress.XtraReports.UI.XRLabel txtInternalID;
        private DevExpress.XtraReports.UI.XRLabel txtSerial;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRLabel txtOrigen;
    }
}
