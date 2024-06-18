namespace Gtt.Labels.UI.WebService.Labels.IndividualLabels
{
    partial class WalkBehind2
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
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.barCode = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrPanel1 = new DevExpress.XtraReports.UI.XRPanel();
            this.txtRefExt = new DevExpress.XtraReports.UI.XRLabel();
            this.txtInternalID = new DevExpress.XtraReports.UI.XRLabel();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.barCode,
            this.xrPanel1});
            this.TopMargin.HeightF = 83.34004F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // barCode
            // 
            this.barCode.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.barCode.AutoModule = true;
            this.barCode.Font = new System.Drawing.Font("Times New Roman", 2F);
            this.barCode.LocationFloat = new DevExpress.Utils.PointFloat(77.78468F, 15.74212F);
            this.barCode.Module = 1F;
            this.barCode.Name = "barCode";
            this.barCode.Padding = new DevExpress.XtraPrinting.PaddingInfo(1, 1, 0, 0, 100F);
            this.barCode.ShowText = false;
            this.barCode.SizeF = new System.Drawing.SizeF(67.98254F, 34.39075F);
            this.barCode.StylePriority.UseFont = false;
            this.barCode.StylePriority.UsePadding = false;
            dataMatrixGS1Generator1.MatrixSize = DevExpress.XtraPrinting.BarCode.DataMatrixSize.Matrix26x26;
            this.barCode.Symbology = dataMatrixGS1Generator1;
            this.barCode.Text = "1234567891212321312312312313213213213123213123123213123213213";
            // 
            // xrPanel1
            // 
            this.xrPanel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.txtRefExt,
            this.txtInternalID});
            this.xrPanel1.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 13F);
            this.xrPanel1.Name = "xrPanel1";
            this.xrPanel1.SizeF = new System.Drawing.SizeF(136.7672F, 46.13287F);
            // 
            // txtRefExt
            // 
            this.txtRefExt.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.txtRefExt.CanGrow = false;
            this.txtRefExt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.txtRefExt.LocationFloat = new DevExpress.Utils.PointFloat(0F, 4.742129F);
            this.txtRefExt.Name = "txtRefExt";
            this.txtRefExt.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtRefExt.SizeF = new System.Drawing.SizeF(67.78467F, 16.99999F);
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
            this.txtInternalID.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.txtInternalID.LocationFloat = new DevExpress.Utils.PointFloat(0F, 21.74212F);
            this.txtInternalID.Name = "txtInternalID";
            this.txtInternalID.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtInternalID.SizeF = new System.Drawing.SizeF(67.78467F, 10F);
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
            // WalkBehind2
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
    }
}
