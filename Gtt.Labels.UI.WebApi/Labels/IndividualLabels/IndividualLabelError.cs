using DevExpress.XtraReports.UI;

namespace Gtt.Labels.UI.WebService.Labels.IndividualLabels
{
    public partial class IndividualLabelError : XtraReport
    {
        public IndividualLabelError(string message)
        {
            InitializeComponent();
            this.BeforePrint += (s, e) =>
            {
                MessageLabel.Text = message;
            };
        }
    }
}