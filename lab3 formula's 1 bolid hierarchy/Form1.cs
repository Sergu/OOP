using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Formula1BolidHierarchy
{
    public partial class Form1 : Form
    {
        public static List<IBolid> listBolids;
        public IBolid currentObject;
        public Control panel;
        public bool changeModFlag;
        public Creator creator;
        public Form1()
        {
            InitializeComponent();
            listBolids = new List<IBolid>();
        }

        public void buttonFirstBolid_Click(object sender, EventArgs e)
        {
            if (panel != null)
            {
                DisposePanel();
            }
            currentObject = new FirstBolid();
            creator = new FirstBolidCreator();
            //currentObject = firstbolid;
            changeModFlag = false;
            PanelCreate(currentObject);
        }

        private void buttonBolid60_Click(object sender, EventArgs e)
        {
            if (panel != null)
            {
                DisposePanel();
            }
            currentObject = new Bolid60();
            creator = new Bolid60Creator();
            //currentObject = bolid60;
            changeModFlag = false;
            PanelCreate(currentObject);
        }

        private void buttonBolidTurbo_Click(object sender, EventArgs e)
        {
            if (panel != null)
            {
                DisposePanel();
            }
            BolidTurbo bolidTurbo = new BolidTurbo();
            creator = new BolidTurboCreator();
            currentObject = bolidTurbo;
            changeModFlag = false;
            PanelCreate(currentObject);
        }

        private void buttonBolidAtmo_Click(object sender, EventArgs e)
        {
            if (panel != null)
            {
                DisposePanel();
            }
            BolidAtmo bolidAtmo = new BolidAtmo();
            creator = new BolidAtmoCreator();
            currentObject = bolidAtmo;
            changeModFlag = false;
            PanelCreate(currentObject);
        }

        private void buttonBolid80_Click(object sender, EventArgs e)
        {
            if (panel != null)
            {
                DisposePanel();
            }
            Bolid80 bolid80 = new Bolid80();
            creator = new Bolid80Creator();
            currentObject = bolid80;
            changeModFlag = false;
            PanelCreate(currentObject);
        }

        private void buttonCurrentBolid_Click(object sender, EventArgs e)
        {
            if (panel != null)
            {
                DisposePanel();
            }
            NewBolid currentbolid = new NewBolid();
            creator = new NewBolidCreator();
            currentObject = currentbolid;
            changeModFlag = false;
            PanelCreate(currentObject);
        }

        public void DisposePanel()
        {
            foreach (Control ctr in panel.Controls)
            {
                panel.Controls.Remove(ctr);
                ctr.Dispose();
            }
            Controls.Remove(panel);
            panel.Dispose();
            panel = null;
        }

        public void ButtonSave_Click(object sender, EventArgs e)
        {
            if (currentObject is FirstBolid)
            {
                foreach (Control ctr in panel.Controls)
                {
                    if (ctr.Name == "textboxName")
                    {
                        currentObject.name = ctr.Text;
                    }
                    if (ctr.Name == "comboboxBody")
                    {
                        this.currentObject.body = ctr.Text;
                    }
                    if (ctr.Name == "comboboxEngine")
                    {
                        this.currentObject.engine = ctr.Text;
                    }
                }
            }
            if (currentObject is Bolid60)
            {
                foreach (Control ctr in panel.Controls)
                {

                    if (ctr.Name == "comboboxNose")
                    {
                        (currentObject as Bolid60).nose = ctr.Text;
                    }
                }
            }
            if (currentObject is BolidAtmo)
            {
                foreach (Control ctr in panel.Controls)
                {
                    if (ctr.Name == "comboboxRearWing")
                    {
                        (currentObject as BolidAtmo).RearWing = ctr.Text;
                    }
                    if (ctr.Name == "textboxDownForce")
                    {
                        (currentObject as BolidAtmo).DownForce = ctr.Text;
                    }
                }
            }
            if (currentObject is BolidTurbo)
            {
                foreach (Control ctr in panel.Controls)
                {
                    if (ctr.Name == "comboboxTurbo")
                    {
                        (currentObject as BolidTurbo).Turbo = ctr.Text;
                    }
                    if (ctr.Name == "textboxDownForce")
                    {
                        (currentObject as BolidTurbo).DownForce = ctr.Text;
                    }
                    if (ctr.Name == "comboboxRearWing")
                    {
                        (currentObject as BolidTurbo).RearWing = ctr.Text;
                    }
                }
            }
            if (currentObject is Bolid80)
            {
                foreach (Control ctr in panel.Controls)
                {
                    if (ctr.Name == "comboboxFrontWing")
                    {
                        (currentObject as Bolid80).FrontWing = ctr.Text;
                    }                    
                }
            }
            if (currentObject is NewBolid)
            {
                foreach(Control ctr in panel.Controls)
                {
                    if (ctr.Name == "comboboxKers")
                    {
                        (currentObject as NewBolid).Kers = ctr.Text;
                    }
                    if (ctr.Name == "comboboxDrs")
                    {
                        (currentObject as NewBolid).Drs = ctr.Text;
                    }
                    if (ctr.Name == "comboboxTurbo")
                    {
                        (currentObject as NewBolid).Turbo = ctr.Text;
                    }
                }
            }
            if (changeModFlag)
            {
                //comboBoxObjects.SelectedText = currentObject.name;
                //listBolids[comboBoxObjects.SelectedIndex] = currentObject;
                (comboBoxObjects.SelectedItem as IBolidSerializer).bolid = currentObject;
                //listBolids[comboBoxObjects.SelectedIndex] = currentObject;
                DisposePanel();
            }
            else
            {
                IBolidSerializer bolidSerializer = creator.FactoryMethod(currentObject);
                
                //comboBoxObjects.Items.Add(currentObject.name);
                //listBolids.Add(currentObject);
                //DisposePanel();
                comboBoxObjects.Items.Add(bolidSerializer);
                //listBolids.Add(currentObject);
                DisposePanel();

            }
        }

        public void PanelCreate(IBolid obj)
        {
            const int shiftY = 30;
            const int shiftX = 90;
            const int comboboxWidth = 170;
            int curentShiftY = 0;
            int curentShiftX = 0;

            panel = new Panel();
            Label labelClassName = new Label();
            labelClassName.Location = new Point(100, curentShiftY);
            curentShiftY += shiftY;
            panel.Controls.Add(labelClassName);
            panel.Location = new Point(10, 150);
            panel.Width = 300;
            panel.Height = 800;
            panel.Controls.Add(labelClassName);
            panel.BackColor = Color.Gray;
            
            if (obj is FirstBolid)
            {
                labelClassName.Text = "FirstBolid";

                Label labelName = new Label();
                labelName.Location = new Point(curentShiftX, curentShiftY);
                labelName.Text = "Name";
                labelName.Width = shiftX;
                curentShiftX += shiftX + 10;
                TextBox textboxName = new TextBox();
                textboxName.Name = "textboxName";
                textboxName.Width = comboboxWidth;
                textboxName.Location = new Point(curentShiftX, curentShiftY);
                curentShiftX = 0;
                curentShiftY += shiftY;

                Label labelEngine = new Label();
                labelEngine.Location = new Point(curentShiftX, curentShiftY);
                labelEngine.Text = "Engine";
                labelEngine.Width = shiftX;
                curentShiftX += shiftX + 10;
                ComboBox comboboxEngine = new ComboBox();
                comboboxEngine.Name = "comboboxEngine";
                comboboxEngine.Width = comboboxWidth;
                comboboxEngine.Location = new Point(curentShiftX, curentShiftY);
                curentShiftX = 0;
                curentShiftY += shiftY;
                comboboxEngine.Items.Add("Volume-4.5 V12");
                comboboxEngine.Items.Add("Volume-3.5 V10");
                comboboxEngine.Items.Add("Volume-2.5 V8");
                comboboxEngine.Items.Add("Volume-2.4 V8");
                comboboxEngine.Items.Add("Volume-1.6 V6");

                Label labelBody = new Label();
                labelBody.Location = new Point(curentShiftX, curentShiftY);
                labelBody.Text = "Body";
                curentShiftX += shiftX + 10;
                labelBody.Width = shiftX;
                ComboBox comboboxBody = new ComboBox();
                comboboxBody.Name = "comboboxBody";
                comboboxBody.Width = comboboxWidth;
                comboboxBody.Location = new Point(curentShiftX, curentShiftY);
                curentShiftX = 0;
                curentShiftY += shiftY;
                comboboxBody.Items.Add("weight-730kg width-195cm");
                comboboxBody.Items.Add("weight-701kg width-190cm");
                comboboxBody.Items.Add("weight-691kg width-180cm");

                panel.Controls.Add(labelName);
                panel.Controls.Add(textboxName);
                panel.Controls.Add(labelBody);
                panel.Controls.Add(labelEngine);
                panel.Controls.Add(comboboxBody);
                panel.Controls.Add(comboboxEngine);
            }
            if (obj is Bolid60)
            {
                labelClassName.Text = "Bolid60";

                Label labelNose = new Label();
                labelNose.Location = new Point(curentShiftX, curentShiftY);
                labelNose.Text = "Nose";
                curentShiftX += shiftX + 10;
                labelNose.Width = shiftX;
                ComboBox comboboxNose = new ComboBox();
                comboboxNose.Location = new Point(curentShiftX, curentShiftY);
                comboboxNose.Name = "comboboxNose";
                comboboxNose.Width = comboboxWidth;
                curentShiftX = 0;
                curentShiftY += shiftY;
                comboboxNose.Items.Add("Ferrari");
                comboboxNose.Items.Add("Lotus");
                comboboxNose.Items.Add("Force India");
                comboboxNose.Items.Add("RedBull");
                comboboxNose.Items.Add("Renault");


                panel.Controls.Add(labelNose);
                panel.Controls.Add(comboboxNose);
            }
            if (obj is BolidTurbo)
            {
                labelClassName.Text = "BolidTurbo";

                Label labelRearWing = new Label();
                labelRearWing.Location = new Point(curentShiftX, curentShiftY);
                labelRearWing.Text = "RearWing";
                curentShiftX += shiftX + 10;
                labelRearWing.Width = shiftX;
                ComboBox comboboxRearWing = new ComboBox();
                comboboxRearWing.Name = "comboboxRearWing";
                comboboxRearWing.Location = new Point(curentShiftX, curentShiftY);
                curentShiftX = 0;
                curentShiftY += shiftY;
                comboboxRearWing.Width = comboboxWidth;
                comboboxRearWing.Items.Add("Lotus");
                comboboxRearWing.Items.Add("Ferrari");
                comboboxRearWing.Items.Add("Mercedes");

                Label labelDownForce = new Label();
                labelDownForce.Location = new Point(curentShiftX, curentShiftY);
                labelDownForce.Text = "DownForce";
                labelDownForce.Width = shiftX;
                curentShiftX += shiftX + 10;
                TextBox textboxDownForce = new TextBox();
                textboxDownForce.Name = "textboxDownForce";
                textboxDownForce.Width = comboboxWidth;
                textboxDownForce.Location = new Point(curentShiftX, curentShiftY);
                curentShiftX = 0;
                curentShiftY += shiftY;

                Label labelTurbo = new Label();
                labelTurbo.Location = new Point(curentShiftX, curentShiftY);
                labelTurbo.Text = "Turbo";
                curentShiftX += shiftX + 10;
                labelTurbo.Width = shiftX;
                ComboBox comboboxTurbo = new ComboBox();
                comboboxTurbo.Name = "comboboxTurbo";
                comboboxTurbo.Width = comboboxWidth;
                comboboxTurbo.Location = new Point(curentShiftX, curentShiftY);
                curentShiftX = 0;
                curentShiftY += shiftY;
                comboboxTurbo.Items.Add("VTG");
                comboboxTurbo.Items.Add("Biturbo");
                comboboxTurbo.Items.Add("TSI");
                comboboxTurbo.Items.Add("Two-stage turbocharging");

                panel.Controls.Add(labelRearWing);
                panel.Controls.Add(comboboxRearWing);
                panel.Controls.Add(labelDownForce);
                panel.Controls.Add(textboxDownForce);
                panel.Controls.Add(labelTurbo);
                panel.Controls.Add(comboboxTurbo);
            }
            if (obj is BolidAtmo)
            {
                labelClassName.Text = "BolidAtmo";

                Label labelRearWing = new Label();
                labelRearWing.Location = new Point(curentShiftX, curentShiftY);
                labelRearWing.Text = "RearWing";
                curentShiftX += shiftX + 10;
                labelRearWing.Width = shiftX;
                ComboBox comboboxRearWing = new ComboBox();
                comboboxRearWing.Name = "comboboxRearWing";
                comboboxRearWing.Width = comboboxWidth;
                comboboxRearWing.Location = new Point(curentShiftX, curentShiftY);
                curentShiftX = 0;
                curentShiftY += shiftY;
                comboboxRearWing.Items.Add("Lotus");
                comboboxRearWing.Items.Add("Ferrari");
                comboboxRearWing.Items.Add("Mercedes");


                Label labelDownForce = new Label();
                labelDownForce.Location = new Point(curentShiftX, curentShiftY);
                labelDownForce.Text = "DownForce";
                labelDownForce.Width = shiftX;
                curentShiftX += shiftX + 10;
                TextBox textboxDownForce = new TextBox();
                textboxDownForce.Name = "textboxDownForce";
                textboxDownForce.Width = comboboxWidth;
                textboxDownForce.Location = new Point(curentShiftX, curentShiftY);
                curentShiftX = 0;
                curentShiftY += shiftY;

                panel.Controls.Add(labelRearWing);
                panel.Controls.Add(labelDownForce);
                panel.Controls.Add(textboxDownForce);
                panel.Controls.Add(comboboxRearWing);
            }
            if (obj is Bolid80)
            {
                labelClassName.Text = "Bolid80";

                Label labelFrontWing = new Label();
                labelFrontWing.Location = new Point(curentShiftX, curentShiftY);
                labelFrontWing.Text = "Front Wing";
                labelFrontWing.Width = shiftX;
                curentShiftX += shiftX + 10;
                ComboBox comboboxFrontWing = new ComboBox();
                comboboxFrontWing.Name = "comboboxFrontWing";
                comboboxFrontWing.Width = comboboxWidth;
                comboboxFrontWing.Location = new Point(curentShiftX, curentShiftY);
                curentShiftX = 0;
                curentShiftY += shiftY;
                comboboxFrontWing.Items.Add("F–Duct");
                comboboxFrontWing.Items.Add("W–Duct");
                comboboxFrontWing.Items.Add("L–Duct");
                comboboxFrontWing.Items.Add("S–Duct");

                panel.Controls.Add(labelFrontWing);
                panel.Controls.Add(comboboxFrontWing);
                
            }
            if (obj is NewBolid)
            {
                labelClassName.Text = "CurrentBolid";

                Label labelTurbo = new Label();
                labelTurbo.Location = new Point(curentShiftX, curentShiftY);
                labelTurbo.Text = "Turbo";
                curentShiftX += shiftX + 10;
                labelTurbo.Width = shiftX;
                ComboBox comboboxTurbo = new ComboBox();
                comboboxTurbo.Name = "comboboxTurbo";
                comboboxTurbo.Width = comboboxWidth;
                comboboxTurbo.Location = new Point(curentShiftX, curentShiftY);
                curentShiftX = 0;
                curentShiftY += shiftY;
                comboboxTurbo.Items.Add("VTG");
                comboboxTurbo.Items.Add("Biturbo");
                comboboxTurbo.Items.Add("TSI");
                comboboxTurbo.Items.Add("Two-stage turbocharging");

                Label labelKers = new Label();
                labelKers.Text = "Kers";
                labelKers.Location = new Point(curentShiftX, curentShiftY);
                labelKers.Width = shiftX + 10;
                curentShiftX += shiftX + 10;
                ComboBox comboboxKers = new ComboBox();
                comboboxKers.Name = "comboboxKers";
                comboboxKers.Width = comboboxWidth;
                comboboxKers.Location = new Point(curentShiftX, curentShiftY);
                curentShiftX = 0;
                curentShiftY += shiftY;
                comboboxKers.Items.Add("true");
                comboboxKers.Items.Add("false");

                Label labelDrs = new Label();
                labelDrs.Text = "Drs";
                labelDrs.Width = shiftX;
                labelDrs.Location = new Point(curentShiftX, curentShiftY);
                curentShiftX += shiftX + 10;
                ComboBox comboboxDrs = new ComboBox();
                comboboxDrs.Name = "comboboxDrs";
                comboboxDrs.Width = comboboxWidth;
                comboboxDrs.Location = new Point(curentShiftX, curentShiftY);
                curentShiftX = 0;
                curentShiftY += shiftY;
                comboboxDrs.Items.Add("true");
                comboboxDrs.Items.Add("false");

                panel.Controls.Add(labelDrs);
                panel.Controls.Add(labelKers);
                panel.Controls.Add(labelTurbo);
                panel.Controls.Add(comboboxDrs);
                panel.Controls.Add(comboboxKers);
                panel.Controls.Add(comboboxTurbo);
            }
            Button buttonSave = new Button();
            buttonSave.Location = new Point(100, curentShiftY);
            curentShiftY += shiftY;
            buttonSave.Text = "Save Changes";
            panel.Controls.Add(buttonSave);
            buttonSave.Click += new EventHandler(ButtonSave_Click);
            Controls.Add(panel);
        }

        public void comboBoxObjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeModFlag = true;
            //currentObject = listBolids[comboBoxObjects.SelectedIndex];
            currentObject = ((IBolidSerializer)comboBoxObjects.SelectedItem).bolid;
            if (panel != null)
            {
                DisposePanel();
            }
            PanelCreate(currentObject);
            SetStartupFields();            
        }

        public void SetStartupFields()
        {
            if (currentObject is FirstBolid)
            {
                foreach (Control ctr in panel.Controls)
                {
                    if (ctr.Name == "textboxName")
                    {
                        ctr.Text = currentObject.name;
                    }
                    if (ctr.Name == "comboboxBody")
                    {
                        ctr.Text = currentObject.body;

                    }
                    if (ctr.Name == "comboboxEngine")
                    {
                        ctr.Text = currentObject.engine;
                    }
                }
            }
            if (currentObject is Bolid60)
            {
                foreach (Control ctr in panel.Controls)
                {
                    
                    if (ctr.Name == "comboboxNose")
                    {
                        ctr.Text = (currentObject as Bolid60).nose;
                    }
                }
            }
            if (currentObject is BolidAtmo)
            {
                foreach (Control ctr in panel.Controls)
                {
                    if (ctr.Name == "comboboxRearWing")
                    {
                        ctr.Text = (currentObject as BolidAtmo).RearWing;
                    }
                    if (ctr.Name == "textboxDownForce")
                    {
                        ctr.Text = (currentObject as BolidAtmo).DownForce;
                    }
                }
            }
            if (currentObject is BolidTurbo)
            {
                foreach (Control ctr in panel.Controls)
                {
                    if (ctr.Name == "comboboxTurbo")
                    {
                        ctr.Text = (currentObject as BolidTurbo).Turbo;
                    }
                    if (ctr.Name == "textboxDownForce")
                    {
                        ctr.Text = (currentObject as BolidTurbo).DownForce;
                    }
                    if (ctr.Name == "comboboxRearWing")
                    {
                        ctr.Text = (currentObject as BolidTurbo).RearWing;
                    }
                }
            }
            if (currentObject is Bolid80)
            {
                foreach (Control ctr in panel.Controls)
                {
                    if (ctr.Name == "comboboxFrontWing")
                    {
                        ctr.Text = (currentObject as Bolid80).FrontWing;
                    }                    
                }
            }
            if (currentObject is NewBolid)
            {
                foreach(Control ctr in panel.Controls)
                {
                    if (ctr.Name == "comboboxKers")
                    {
                        ctr.Text = (currentObject as NewBolid).Kers;
                    }
                    if (ctr.Name == "comboboxDrs")
                    {
                        ctr.Text = (currentObject as NewBolid).Drs;
                    }
                    if (ctr.Name == "comboboxTurbo")
                    {
                        ctr.Text = (currentObject as NewBolid).Turbo;
                    }
                }
            }
        }

        private void buttonSerialize_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter;
            FileInfo file = new FileInfo("serializeObjects.txt");
            streamWriter = file.AppendText();
            foreach (IBolidSerializer car in comboBoxObjects.Items)
            {
                streamWriter.WriteLine(car.Serialize());
            }
            streamWriter.Close();
        }

        public void buttonDeserialize_Click(object sender, EventArgs e)
        {
            comboBoxObjects.Items.Clear();
            using (StreamReader streamReader = new StreamReader("serializeObjects.txt"))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    comboBoxObjects.Items.Add(Deserialization.Deserialize(line));
                }
            }
            File.Delete("serializeObjects.txt");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            File.Delete("serializeObjects.txt");
        }

        public  void buttonRemoveObject_Click(object sender, EventArgs e)
        {
            comboBoxObjects.Items.Remove(comboBoxObjects.SelectedItem);
            comboBoxObjects.SelectedIndex = -1;
        }
    }
}
