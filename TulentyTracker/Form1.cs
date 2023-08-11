using TulentyTracker.BuisnesObjects;
using TulentyTracker.Helpers;
using TulentyTracker.Views;
using System.Reflection;
using TulentyTracker.Attributes;

namespace TulentyTracker
{
    public partial class Form1 : Form
    {
        Type CurrentType { get; set; } = typeof(Object);

        public Form1()
        {
            InitializeComponent();
        }

        #region CRUD операции сущностей

        private void AddHabitButton_Click(object sender, EventArgs e)
        {
            var db = ModelContext.GetContext();

            db.Database.EnsureCreated();

            var CategoryName = !string.IsNullOrEmpty(HabbitCategoryComboBox?.SelectedItem?.ToString()) ? HabbitCategoryComboBox.SelectedItem.ToString() : "Unknown";

            var category1 = HabbitCategoryComboBox?.SelectedItem as Category;

            var category = db.Categories.FirstOrDefault(f => f.Name == CategoryName);

            // создаем объект Habbit
            Habbit newHabbit = new Habbit(HabbitNametextBox.Text, HabbitDescriptionTextBox.Text/*, db.Categories.FirstOrDefault(f => f.Name == CategoryName) ?? new Category("Unknown", "")*/);

            newHabbit.Category = category;

            // добавляем в бд
            db.Habbits.AddRange(newHabbit);
            db.SaveChanges();
        }

        private void AddCategoryButton_Click(object sender, EventArgs e)
        {
            var db = ModelContext.GetContext();
            
            db.Database.EnsureCreated();

            // создаем объект Category
            Category newCategory = new Category(CategoryNameTextBox.Text, CategoryDescriptionTextBox.Text);

            // добавляем в бд
            db.Categories.AddRange(newCategory);
            db.SaveChanges();
            
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            var db = ModelContext.GetContext();

            db.Database.EnsureCreated();

            var PermissionName = !string.IsNullOrEmpty(UserPermissionComboBox.SelectedItem.ToString()) ? UserPermissionComboBox.SelectedItem.ToString() : "Unknown";

            // создаем объект User
            User newUser = new User(UserNameTextBox.Text, UserSurenameTextBox.Name, UserBirthDateTimePicker.Value, UserCountryTextBox.Text);

            var permission = db.Permissions.FirstOrDefault(f => f.Name == PermissionName);

            newUser.Permission = permission;

            // добавляем в бд
            db.Users.AddRange(newUser);
            db.SaveChanges();

        }

        /// <summary>
        /// Какушка в попе
        /// </summary>
        /// <remarks> Пися пися </remarks>
        /// <param name="sender"> Отправитель писи </param>
        /// <param name="e"> Шлепочек по попке </param>
        private void AddPermissionButton_Click(object sender, EventArgs e)
        {
            var db = ModelContext.GetContext();

            db.Database.EnsureCreated();
                
            // создаем объект User
            Permission newPermission = new Permission(PermissionNameTextBox.Text);

            // добавляем в бд
            db.Permissions.AddRange(newPermission);
            db.SaveChanges();

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            var ObjectsList = dataGridView1.SelectedRows;
            
            if (ObjectsList.Count > 0)
            {
                UpdateCurrentRows(ObjectsList);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Обновление списков в комбобоксах


        private void HabbitCategoryComboBox_Enter(object sender, EventArgs e)
        {
            var db = ModelContext.GetContext();

            var categories = db.Categories.ToList();

            HabbitCategoryComboBox.DataSource = categories.Select(s => s.Name).ToList();
        }

        private void UserPermissionComboBox_Enter(object sender, EventArgs e)
        {
            var db = ModelContext.GetContext();

            var permissions = db.Permissions.ToList();

            UserPermissionComboBox.DataSource = permissions.Select(s => s.Name).ToList();
        }

        #endregion

        #region Навигационные кнопки

        private void NavButtonAdding_Click(object sender, EventArgs e)
        {
            ShowAddingPanel();
            CurrentType = typeof(Object);
        }

        private void NavButtonHabbits_Click(object sender, EventArgs e)
        {
            var db = ModelContext.GetContext();

            db.Database.EnsureCreated();

            var entityList = db.Habbits.ToList();

            dataGridView1.DataSource = entityList;

            CurrentType = typeof(Habbit);

            dataGridView1.Show();
            dataGridView1.Refresh();

            ShowDataPanel();
        }

        private void NavButtonCategory_Click(object sender, EventArgs e)
        {
            var db = ModelContext.GetContext();

            db.Database.EnsureCreated();

            var entityList = db.Categories.ToList();

            dataGridView1.DataSource = entityList;

            CurrentType = typeof(Category);

            dataGridView1.Refresh();

            ShowDataPanel();
        }

        private void UserButton_Click(object sender, EventArgs e)
        {
            var db = ModelContext.GetContext();

            db.Database.EnsureCreated();

            var entityList = db.Users.ToList();

            dataGridView1.DataSource = entityList;

            CurrentType = typeof(User);

            dataGridView1.Show();
            dataGridView1.Refresh();

            ShowDataPanel();
        }

        private void PerminssionButton_Click(object sender, EventArgs e)
        {
            var db = ModelContext.GetContext();

            db.Database.EnsureCreated();

            var entityList = db.Permissions.ToList();

            dataGridView1.DataSource = entityList;

            CurrentType = typeof(Permission);

            dataGridView1.Show();
            dataGridView1.Refresh();
            
            ShowDataPanel();
        }

        #endregion

        #region Вспомогательные методы

        private void ShowDataPanel()
        {
            DataPanel.Visible = true;
            DataPanel.BringToFront();
        }
        
        private void ShowAddingPanel()
        {
            AddingPanel.Visible = true;
            DataPanel.Visible = false;

        }

        private void UpdateCurrentRows(DataGridViewSelectedRowCollection ObjectsList)
        {
            try
            {
                if (CurrentType == null)
                    throw new Exception("Не выбран тип данных. Объект CurrentType не задан");

                var db = ModelContext.GetContext();

                var typeName = "TulentyTracker.Views." + CurrentType.Name + "_DetailView";

                Type? viewType = Type.GetType(typeName);

                // Создаем экземпляр DetailView
                object? viewInstance = viewType?.GetConstructors().FirstOrDefault(w => w.GetParameters().Count() == 0)?.Invoke(new object[] { });

                var detailView = viewInstance as Form;

                if (detailView == null)
                    return;

                // Получаемо бъект из базы
                int index = dataGridView1.SelectedRows[0].Index;
                Guid id = Guid.Empty;
                bool converted = Guid.TryParse(dataGridView1[0, index].Value.ToString(), out id);

                if (converted == false)
                    return;

                // Ищем объект в базе
                object? sourceEntity = db?.Find(CurrentType ?? typeof(Object), id);
                if (sourceEntity == null)
                    return;

                #region Заполняем поля DetailView

                var entityProperties1 = CurrentType?.GetProperties().ToList();
                var entAtrs = entityProperties1.Select(s => !s.GetCustomAttributes(true).Select(s => s as NonBindingAttribute).Where(w => w != null).Any()).ToList();

                var entityProperties = CurrentType?.GetProperties().Where(w => !w.GetCustomAttributes(true).Select(s => s as NonBindingAttribute).Where(w => w != null).Any()).ToList();
                //var entityProperties = CurrentType?.GetProperties().Where(w => !w.GetCustomAttributes(true).Any()).ToList();
                //var viewProperties = viewType?.GetProperties().Where(w => w.PropertyType != typeof(List<object>)).ToList();

                if (entityProperties != null && entityProperties.Any())
                {
                    foreach (var property in entityProperties)
                    {
                        //CategoryId_Control
                        var propName = CurrentType?.Name + property.Name + "_Control";
                        var sourceField = viewType?.GetField(propName);
                        var controller = sourceField?.GetValue(detailView);

                        PropertyInfo? targetField = null;
                        if (controller?.GetType() == typeof(TextBox) || controller?.GetType() == typeof(ComboBox))
                            targetField = sourceField?.FieldType?.GetProperty("Text");
                        //else if (controller?.GetType() == typeof(ComboBox))
                        //{
                        //    //targetField = sourceField?.FieldType?.GetProperty("SelectedItem");
                        //    targetField = sourceField?.FieldType?.GetProperty("Text");
                        //}
                        else
                            targetField = sourceField?.FieldType?.GetProperty("Value");

                        if (targetField == null)
                            throw new Exception("targetField is null");

                        // Получаем значение свойства из Объекта
                        var targetType = targetField?.PropertyType;
                        var value = property?.GetValue(sourceEntity);

                        var convertedValue = targetField?.PropertyType?.GetConstructors().FirstOrDefault(w => w.GetParameters().Count() == 0)?.Invoke(new object[] { });

                        // Записываем значение свойства в DetailView
                        if (targetField?.PropertyType == typeof(string))
                        {
                            var convertedValue1 = property?.PropertyType?.GetMethod("ToString", Type.EmptyTypes);
                            convertedValue = convertedValue1?.Invoke(value, new object[] { });
                        }
                        else
                            convertedValue = Convert.ChangeType(value, targetField?.PropertyType ?? typeof(object));
                        targetField?.SetValue(controller, convertedValue);
                    }
                }

                #endregion

                var result = detailView.ShowDialog();

                if (result == DialogResult.Cancel)
                    return;

                // Создаем экземпляр Entity
                object? entityInstance = CurrentType?.GetConstructors().FirstOrDefault(w => w.GetParameters().Count() == 0)?.Invoke(new object[] { });

                entityProperties = CurrentType?.GetProperties().Where(w => w.PropertyType != typeof(Guid) && !w.GetCustomAttributes(true).Select(s => s as NonBindingAttribute).Where(w => w != null).Any()).ToList();

                #region Заполняем поля объекта Entity

                if (entityProperties != null && entityProperties.Any())
                {
                    foreach (var property in entityProperties)
                    {
                        // Получаем значение свойства из DetailView
                        var propName = CurrentType?.Name + property.Name + "_Control";
                        var sourceField = viewType?.GetField(propName);
                        var controller = sourceField?.GetValue(detailView);

                        var targetFieldType = sourceField?.FieldType;
                        var targetField = targetFieldType?.GetProperty("Text");

                        var valueType = targetField?.PropertyType;
                        var value = targetField?.GetValue(controller);
                        var nameValue = "";

                        if (controller?.GetType() == typeof(TextBox))
                        {
                            targetField = sourceField?.FieldType?.GetProperty("Text");
                            value = targetField?.GetValue(controller);

                            // Записываем значение свойства в объект
                            var convertedValue = Convert.ChangeType(value, property?.PropertyType);
                            property.SetValue(sourceEntity, convertedValue);
                        }
                        else if (controller?.GetType() == typeof(ComboBox))
                        {
                            // Получаем значение Guid из DetailView
                            var propNameGuid = CurrentType?.Name + property.Name + "Id" + "_Control";
                            var sourceFieldGuid = viewType?.GetField(propNameGuid);
                            var controllerGuid = sourceFieldGuid?.GetValue(detailView);

                            var targetFieldTypeGuid = sourceFieldGuid?.FieldType;
                            var targetFieldGuid = targetFieldTypeGuid?.GetProperty("Text");

                            var valueTypeGuid = targetFieldGuid?.PropertyType;
                            var valueGuid = targetFieldGuid?.GetValue(controllerGuid);

                            //targetField = sourceField?.FieldType?.GetProperty("SelectedItem");
                            targetFieldGuid = sourceFieldGuid?.FieldType?.GetProperty("Text");
                            var strGuidValue = targetFieldGuid?.GetValue(controllerGuid);

                            var GuidValue = new Guid(strGuidValue?.ToString() ?? "");

                            value = db.Find(property.PropertyType, GuidValue);

                            property.SetValue(sourceEntity, value);
                        }
                        else
                        {
                            targetField = sourceField?.FieldType?.GetProperty("Value");

                            if (targetField == null)
                                throw new Exception("targetField is null");

                            if (value == null)
                            {
                                targetField = sourceField?.FieldType?.GetProperty("Value");
                                value = targetField?.GetValue(controller);
                            }

                            //targetField = sourceField?.FieldType?.GetProperty("Text");
                            //var name = targetField?.GetValue(controller);

                            // Ищем объект в базе
                            //if (!string.IsNullOrEmpty(nameValue))
                            //{
                            //    object? sourceEntity2 = db?.Find(CurrentType ?? typeof(Object), nameValue);
                            //    property.SetValue(sourceEntity, sourceEntity2);
                            //}
                            //else
                            //{
                            // Записываем значение свойства в объект
                            var convertedValue = Convert.ChangeType(value, property?.PropertyType);
                            property.SetValue(sourceEntity, convertedValue);
                            //}
                        }
                    }
                }

                #endregion

                // Обновляем объект в базе
                //sourceEntity = entityInstance;
                db?.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

    }
}