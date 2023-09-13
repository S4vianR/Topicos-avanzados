using System.Security.Cryptography.X509Certificates;

namespace E_PizzaBite
{
    public partial class EPizzaBiteForm : Form
    {
        // Declare object with default values (nothing selected)
        private Pizza _pizza = new Pizza(Pizza.PizzaType.Regular, Pizza.PizzaSize.Medium, new List<Pizza.Ingredients>());

        // Declare lists
        private List<Pizza.Ingredients> _ingredients = new List<Pizza.Ingredients>();

        // Create list of pizzas that also contains the ingredients
        private List<Pizza> _pizzaListWithIngredients = new List<Pizza>();

        // Declare variables
        private int _numOfPizzas = 0;

        // Reset Pizza options and Ingredients
        private void ResetPizza(object sender, EventArgs e)
        {
            ResetIngredients();
            ChooseIngPRadioButton.Checked = false;
            SpecialsRadioButton.Checked = false;
            SmallRadioButton.Checked = false;
            MediumRadioButton.Checked = false;
            LargeRadioButton.Checked = false;
        }

        private void ResetIngredients()
        {
            foreach (Control control in IngredientsGroupBox.Controls)
            {
                if (control is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                    _ingredients.Clear();
                    IngredientsListTextBox.Text = "";
                }
            }
        }

        private void ResetEverything(object sender, EventArgs e)
        {
            ResetPizza(sender, e);

            _pizzaListWithIngredients.Clear();
            _ingredients.Clear();
            _numOfPizzas = 0;

            NumPizzasLabel.Text = "0";
            SpecialsRadioButton.Checked = false;
            ChooseIngPRadioButton.Checked = false;
            SmallRadioButton.Checked = false;
            MediumRadioButton.Checked = false;
            LargeRadioButton.Checked = false;

            foreach (Control control in SpecialsGroupBox.Controls)
            {
                if (control is ListBox listBox)
                {
                    listBox.SelectedIndex = -1;
                }
            }
        }

        // Method to add the pizza to the list
        private void AddPizzaToList(Pizza pizza)
        {
            _pizzaListWithIngredients.Add(pizza);
        }

        public EPizzaBiteForm()
        {
            InitializeComponent();
            //this.Resize += new EventHandler(EPizzaBiteForm_Resize);
        }

        private void SpecialsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SpecialsGroupBox.Visible = true;
            IngredientsGroupBox.Enabled = false;
        }

        private void ChooseIngPRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SpecialsGroupBox.Visible = false;
            IngredientsGroupBox.Enabled = true;
        }

        private void EPizzaBiteForm_Load(object sender, EventArgs e)
        {
            ChooseIngPRadioButton.Checked = true;
            SpecialsRadioButton.Checked = true;
            SmallRadioButton.Checked = true;
            MediumRadioButton.Checked = true;
            LargeRadioButton.Checked = true;
            ResetEverything(sender, e);
        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            // Declare variables
            double total = 0;

            // Calculate total
            foreach (Pizza pizza in _pizzaListWithIngredients)
            {
                total += pizza.CalculatePrice(pizza.Type);
            }

            // Show total
            MessageBox.Show("Total: " + total.ToString("C"), "Total", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reset the whole application
            ResetEverything(sender, e);
        }



        private void AddButton_Click(object sender, EventArgs e)
        {
            // Check if the user has selected a pizza type
            if (SpecialsRadioButton.Checked || ChooseIngPRadioButton.Checked)
            {
                // Check if the user has selected a pizza size
                if (SmallRadioButton.Checked || MediumRadioButton.Checked || LargeRadioButton.Checked)
                {
                    // Check if the user has selected a pizza type
                    if (SpecialsRadioButton.Checked)
                    {
                        // Check if the user has selected a special pizza
                        if (SpecialsLIstBox.SelectedIndex != -1)
                        {
                            // Add pizza to list
                            // Check the type of the pizza with the selected index
                            switch (SpecialsLIstBox.SelectedIndex)
                            {
                                case 0:
                                    _pizza.Type = Pizza.PizzaType.Carbonara;
                                    break;
                                case 1:
                                    _pizza.Type = Pizza.PizzaType.Capricciosa;
                                    break;
                                case 2:
                                    _pizza.Type = Pizza.PizzaType.BBQChicken;
                                    break;
                                case 3:
                                    _pizza.Type = Pizza.PizzaType.Supreme;
                                    break;
                                case 4:
                                    _pizza.Type = Pizza.PizzaType.Margherita;
                                    break;
                            }

                            AddPizzaToList(_pizza);
                            _numOfPizzas++;
                            NumPizzasLabel.Text = _numOfPizzas.ToString();
                            ResetPizza(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Please select a special pizza.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        // Check if the user has selected ingredients
                        if (_ingredients.Count != 0)
                        {
                            // Add pizza to list
                            AddPizzaToList(_pizza);
                            _numOfPizzas++;
                            NumPizzasLabel.Text = _numOfPizzas.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Please select ingredients.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a pizza size.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a pizza type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Reset the pizza
            ResetPizza(sender, e);

            // Enable the pay button if there are pizzas in the list
            if (_numOfPizzas > 0)
            {
                PayButton.Enabled = true;
            }
            else
            {
                PayButton.Enabled = false;
            }
        }


        // Method to check if the CheckBoxes from the IngredientsGroupBox are checked
        private void CheckIngredients()
        {
            foreach (Control control in IngredientsGroupBox.Controls)
            {
                if (control is CheckBox checkBox)
                {
                    if (checkBox.Checked)
                    {
                        Pizza.Ingredients ingredient = (Pizza.Ingredients)Enum.Parse(typeof(Pizza.Ingredients), checkBox.Tag.ToString());
                        _ingredients.Add(ingredient);
                    }
                }
            }
            IngredientsListTextBox.Text = string.Join(", ", _ingredients);
        }

        // Method to check which special pizza is selected from the SpecialListBox
        private void CheckSpecialPizza()
        {
            foreach (Control control in SpecialsGroupBox.Controls)
            {
                if (control is ListBox listBox)
                {
                    switch (listBox.SelectedIndex)
                    {
                        case 0:
                            _pizza.Type = Pizza.PizzaType.Carbonara;
                            break;
                        case 1:
                            _pizza.Type = Pizza.PizzaType.Capricciosa;
                            break;
                        case 2:
                            _pizza.Type = Pizza.PizzaType.BBQChicken;
                            break;
                        case 3:
                            _pizza.Type = Pizza.PizzaType.Supreme;
                            break;
                    }
                    SpecialsLIstBox.SelectedIndex = listBox.SelectedIndex;
                }
            }
        }


        private void AddIngredientsButton_Click(object sender, EventArgs e)
        {
            CheckIngredients();
            IngredientsGroupBox.Enabled = false;
        }

        private void SmallRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _pizza.Size = Pizza.PizzaSize.Small;
        }

        private void MediumRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _pizza.Size = Pizza.PizzaSize.Medium;
        }

        private void LargeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _pizza.Size = Pizza.PizzaSize.Large;
        }

        private void AddSpecialPizzaButton_Click(object sender, EventArgs e)
        {
            CheckSpecialPizza();
            SpecialsGroupBox.Enabled = false;
        }

        private void ResetAppButton_Click(object sender, EventArgs e)
        {
            // Reset the whole application
            ResetEverything(sender, e);

        }
    }
}