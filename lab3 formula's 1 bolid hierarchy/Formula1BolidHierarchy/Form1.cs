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
using System.Reflection;
using Formula1BolidHierarchy.Bolids;
using Formula1BolidHierarchy.Serializations;
using Formula1BolidHierarchy.Serializers;
using Formula1BolidHierarchy.Deserializers;
using Formula1BolidHierarchy.Factory.BolidDeserializerCreators;
using Formula1BolidHierarchy.Factory.BolidSerializerCreators;
using Formula1BolidHierarchy.Repository;
using Formula1BolidHierarchy.Handlers;
using Formula1BolidHierarchy;
using PluginContracts;

namespace Formula1BolidHierarchy
{
    public partial class Form1 : Form
    {
        public static List<Bolid> listBolids;
        public Bolid currentBolid;
        public BolidCreator bolidCreator;
        public bool changeModFlag = false;
        //public Creator creator;
        public BolidDeserializerCreator currentBolidDeserCreator;
        public BolidSerializerCreator currentBolidSerCreator;
        public List<BolidSerializer> listBolidSerializers;
        public List<BolidDeserializer> listBolidDeserializers;
        public BolidsRepository bolidsRepository;
        public BolidEditingCreator editingCreator;
        private Label[] labelsForBolids;
        private TextBox[] textboxForBolids;
        int currentComboboxIndex;
        public Form1()
        {
            InitializeComponent();
            bolidsRepository = new BolidsRepository();
            comboBoxBolids.Items.AddRange(CarsVarietyRepository.ListCars.ToArray());
            labelsForBolids = new Label[] { label1, label2, label3, label4, label5, label6, label7 };
            textboxForBolids = new TextBox[] { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7 };
            listBolids = bolidsRepository.Bolid;
            listBolidSerializers = new List<BolidSerializer>();
            listBolidDeserializers = new List<BolidDeserializer>();
        }       

        public void ButtonSafe_Click(object sender, EventArgs e)
        {
            //if (changeModFlag)
            //{
            //    //comboBoxObjects.SelectedText = currentObject.name;
            //    listBolids[comboBoxObjects.SelectedIndex] = currentBolid;
            //    comboBoxObjects.Items[comboBoxObjects.SelectedIndex] = currentBolid;
            //    //listBolids[comboBoxObjects.SelectedIndex] = currentObject;
            //    DisposePanel();
            //}
            //else
            //{
            //    listBolidDeserializers.Add(currentBolidDeserCreator.FactoryMethod());
            //    listBolidSerializers.Add(currentBolidSerCreator.FactoryMethod());
            //    listBolids.Add(currentBolid);
            //    comboBoxObjects.Items.Add(currentBolid);
            //    DisposePanel();
            //}
        }

        public void comboBoxObjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> fields = new List<string>();
            currentBolid = (Bolid)comboBoxObjects.SelectedItem;
            currentComboboxIndex = comboBoxObjects.SelectedIndex;
            int index = GetIndexOfHandler(currentBolid);
            comboBoxBolids.SelectedIndex = index;
            editingCreator = EditingCreatorRepository.ListOfEditingCreators[comboBoxBolids.SelectedIndex];
            editingCreator.FactoryMethod(currentBolid, fields);
            HandlerFromFields handler = HandlersRepository.ListOfHandlers[comboBoxBolids.SelectedIndex];
            ChangeFieldAccordingWithHandler(handler);
            FillFields(fields);
            changeModFlag = true;
            //bolidsRepository.Bolid.RemoveAt(currentComboboxIndex);
        }
        private int GetIndexOfHandler(Bolid player)
        {
            for (int i = 0; i < CarsVarietyRepository.ListCars.Count; i++)
                if (player.ToString().Contains("Bolid: " + CarsVarietyRepository.ListCars[i]))
                    return i;
            return -1;
        }

        private void FillFields(List<string> fields)
        {
            textBoxName.Text = fields[0];
            textBoxEngine.Text = fields[1];
            textBoxBody.Text = fields[2];
            for (int i = 3; i < fields.Count; i++)
            {
                textboxForBolids[i - 3].Text = fields[i];
            }
        }

        private void buttonSerialize_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter;
            FileInfo file = new FileInfo("serializeObjects.txt");
            streamWriter = file.AppendText();
            int i = 0;
            foreach (Bolid car in comboBoxObjects.Items)
            {
                streamWriter.WriteLine(listBolidSerializers[i].Serialize(car));
                i++;
            }
            streamWriter.Close();
        }

        public void buttonDeserialize_Click(object sender, EventArgs e)
        {
            int i=0;
            using (StreamReader streamReader = new StreamReader("serializeObjects.txt"))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    comboBoxObjects.Items.Add(listBolidDeserializers[i].Deserialize(line));
                    i++;
                }
            }
            File.Delete("serializeObjects.txt");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            File.Delete("serializeObjects.txt");
            listBolids.Clear();
        }

        public  void buttonRemoveObject_Click(object sender, EventArgs e)
        {
            bolidsRepository.Bolid.RemoveAt(comboBoxObjects.SelectedIndex);
            listBolidSerializers.RemoveAt(comboBoxObjects.SelectedIndex);
            comboBoxObjects.Items.Clear();
            comboBoxObjects.Items.AddRange(bolidsRepository.Bolid.ToArray());
            comboBoxObjects.SelectedIndex = -1;
        }

        private void comboBoxBolids_SelectedIndexChanged(object sender, EventArgs e)
        {
            HandlerFromFields handler = HandlersRepository.ListOfHandlers[comboBoxBolids.SelectedIndex];
            ChangeFieldAccordingWithHandler(handler);
            changeModFlag = false;
        }
        private void ChangeFieldAccordingWithHandler(HandlerFromFields handler)
        {
            for (int i = 0;i<handler.LabelNames.Length;i++)
            {
                labelsForBolids[i].Text = handler.LabelNames[i];
                labelsForBolids[i].Visible = true;
                textboxForBolids[i].Visible = true;
            }
            for (int i = handler.LabelNames.Length;i<labelsForBolids.Length;i++)
            {
                labelsForBolids[i].Text = "";
                labelsForBolids[i].Visible = false;
                textboxForBolids[i].Visible = false;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!changeModFlag)
            {
                bolidCreator = BolidCreatorRepository.ListBolidCreators[comboBoxBolids.SelectedIndex];
                currentBolidSerCreator = BolidSerializerRepository.Bolids[comboBoxBolids.SelectedIndex];
                currentBolidDeserCreator = BolidDeserializerRepository.Bolid[comboBoxBolids.SelectedIndex];
                List<string> fields = new List<string>()
                {
                    textBoxName.Text,textBoxEngine.Text,textBoxBody.Text,textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text,textBox5.Text,textBox6.Text,textBox7.Text
                };
                List<Bolid> tmpBolidLists = bolidsRepository.Bolid;
                tmpBolidLists.Add(bolidCreator.FactoryMethod(fields));
                bolidsRepository.Bolid = tmpBolidLists;
                comboBoxObjects.Items.Clear();
                comboBoxObjects.Items.AddRange(bolidsRepository.Bolid.ToArray());
                listBolidDeserializers.Add(currentBolidDeserCreator.FactoryMethod());
                listBolidSerializers.Add(currentBolidSerCreator.FactoryMethod());
                ClearFields();
            }
            else
            {
                bolidCreator = BolidCreatorRepository.ListBolidCreators[comboBoxBolids.SelectedIndex];
                List<string> fields = new List<string>() { textBoxName.Text, textBoxEngine.Text, textBoxBody.Text, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text };
                bolidsRepository.Bolid.Insert(currentComboboxIndex, bolidCreator.FactoryMethod(fields));
                bolidsRepository.Bolid.RemoveAt(currentComboboxIndex + 1);
                comboBoxObjects.Items.Clear();
                comboBoxObjects.Items.AddRange(bolidsRepository.Bolid.ToArray());
                ClearFields();
                changeModFlag = false;
            }
        }

        private void ClearFields()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
            textBox7.Text = string.Empty;
            textBoxName.Text = string.Empty;
            textBoxEngine.Text = string.Empty;
            textBoxBody.Text = string.Empty;           
        }

        private void buttonPlugin_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                PluginsController controller = new PluginsController();
                controller.FindPlugins(file);
                ICollection<IBolidPlugin> plugins = controller.LoadAssembleys<IBolidPlugin>(typeof(IBolidPlugin));

                foreach (var item in plugins)
                {
                    BolidCreatorRepository.ListBolidCreators.Add(item.bolidCreator);
                    BolidDeserializerRepository.Bolid.Add(item.bolidDeserializerCreator);
                    BolidSerializerRepository.Bolids.Add(item.bolidSerializerCreator);
                    BolidsTypesRepository.ListOfDriversTypes.Add(item.typeOfBolid);
                    CarsVarietyRepository.ListCars.Add(item.bolidName);
                    HandlersRepository.ListOfHandlers.Add(item.handler);
                    EditingCreatorRepository.ListOfEditingCreators.Add(item.bolidEditingCreator);
                    comboBoxBolids.Items.Clear();
                    comboBoxBolids.Items.AddRange(CarsVarietyRepository.ListCars.ToArray());
                }
            }
            openFileDialog1.Dispose();
        }
    }
}
