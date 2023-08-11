using System.Data;
using TulentyTracker.Helpers;

namespace TulentyTracker.Views
{
    public partial class Habbit_DetailView : BaseForm
    {
        public Habbit_DetailView()
        {
            InitializeComponent();

            var db = ModelContext.GetContext();

            var categories = db.Categories.ToList();

            HabbitCategory_Control.DataSource = categories.Select(s => s.Name).ToList();
        }

        private void HabbitCategory_Control_SelectedValueChanged(object sender, EventArgs e)
        {
            var db = ModelContext.GetContext();

            var categoryName = HabbitCategory_Control.Text;

            var category = db.Categories.FirstOrDefault(w => w.Name == categoryName);

            if (category != null)
            {
                HabbitCategoryId_Control.Text = category?.Name;
            }
        }
    }
}
