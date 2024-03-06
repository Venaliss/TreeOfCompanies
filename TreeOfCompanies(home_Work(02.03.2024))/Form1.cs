using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using Newtonsoft.Json.Linq;


namespace TreeOfCompanies_home_Work_02._03._2024__
{
    public partial class TreeOfCompanies : Form
    {
        public TreeOfCompanies()
        {
            InitializeComponent();
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            treeView.Nodes.Clear();

            string xmlFile = "companies.xml";
            string jsonFile = "companies.json";

            if (File.Exists(xmlFile))
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(xmlFile);

                TreeNode xmlNode = new TreeNode(xmlDoc.DocumentElement.Name);
                treeView.Nodes.Add(xmlNode);

                AddXmlNode(xmlDoc.DocumentElement, xmlNode);
            }

            if (File.Exists(jsonFile))
            {
                string jsonText = File.ReadAllText(jsonFile);
                JObject jsonObject = JObject.Parse(jsonText);

                TreeNode jsonNode = new TreeNode("companies.json");
                treeView.Nodes.Add(jsonNode);

                AddJsonNode(jsonObject, jsonNode);
            }
        }

        private void AddXmlNode(XmlNode xmlNode, TreeNode treeNode)
        {
            foreach (XmlNode childNode in xmlNode.ChildNodes)
            {
                TreeNode childTreeNode = new TreeNode(childNode.Name);
                treeNode.Nodes.Add(childTreeNode);

                if (childNode.HasChildNodes)
                {
                    AddXmlNode(childNode, childTreeNode);
                }
                else
                {
                    childTreeNode.Text = $"{childNode.Name}: {childNode.InnerText}";
                }
            }
        }
        private void AddJsonNode(JToken token, TreeNode parentNode)
        {
            if (token is JObject jObject)
            {
                AddJsonObjectNode(jObject, parentNode);
            }
            else if (token is JArray jArray)
            {
                AddJsonArrayNode(jArray, parentNode);
            }
        }

        private void AddJsonObjectNode(JObject jObject, TreeNode parentNode)
        {
            foreach (JProperty property in jObject.Properties())
            {
                TreeNode propertyNode = new TreeNode(property.Name);

                if (property.Value is JObject obj)
                {
                    AddJsonObjectNode(obj, propertyNode);
                }
                else if (property.Value is JArray arr)
                {
                    AddJsonArrayNode(arr, propertyNode);
                }
                else
                {
                    propertyNode.Nodes.Add(property.Value.ToString());
                }

                parentNode.Nodes.Add(propertyNode);
            }
        }

        private void AddJsonArrayNode(JArray jArray, TreeNode parentNode)
        {
            int index = 0;
            string currentNodeText = parentNode.Text;

            if (currentNodeText.EndsWith("ies"))
            {
                currentNodeText = currentNodeText.Substring(0, currentNodeText.Length - 3) + "y";
            }
            else
            {
                currentNodeText = currentNodeText.TrimEnd('s');
            }
            foreach (JToken token in jArray)
            {
                TreeNode itemNode = new TreeNode(currentNodeText + " " + index);

                if (token is JObject obj)
                {
                    AddJsonObjectNode(obj, itemNode);
                }
                else if (token is JArray arr)
                {
                    AddJsonArrayNode(arr, itemNode);
                }
                else
                {
                    itemNode.Nodes.Add(token.ToString());
                }

                parentNode.Nodes.Add(itemNode);
                index++;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void TreeOfCompanies_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("companies.xml");
            dataGridView.DataSource = ds.Tables[0];           
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            TreeOfCompany_2 form = new TreeOfCompany_2();
            form.Show();
        }
    }
}
