using System.Data;
using TulentyTracker.Helpers;

namespace TulentyTracker.Views
{
    public partial class User_DetailView : BaseForm
    {
        public User_DetailView()
        {
            InitializeComponent();

            var db = ModelContext.GetContext();

            var permissions = db.Permissions.ToList();

            UserPermission_Control.DataSource = permissions.Select(s => s.Name).ToList();
        }

        private void UserPermission_Control_SelectedValueChanged(object sender, EventArgs e)
        {
            var db = ModelContext.GetContext();

            var permissionName = UserPermission_Control.Text;

            var perission = db.Permissions.FirstOrDefault(w => w.Name == permissionName);

            if (perission != null)
            {
                UserPermissionId_Control.Text = perission?.Id.ToString();
            }
        }

        private void UserPermissionId_Control_TextChanged(object sender, EventArgs e)
        {
            var db = ModelContext.GetContext();

            var permissionId = UserPermissionId_Control.Text;

            var perission = db.Permissions.FirstOrDefault(w => w.Id == new Guid(permissionId));

            if (perission != null)
            {
                UserPermission_Control.Text = perission?.Name.ToString();
            }
        }
    }
}
