using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml;


namespace lab4
{
    public partial class FormMain : Form
    {
        public static List<Picture> Pictures = new List<Picture>();
        public static List<Book> Books = new List<Book>();

        public static List<Picture> currPictures = new List<Picture>();
        public static List<Book> currBooks = new List<Book>();

        public FormMain()
        {
            InitializeComponent();
            PicturesTable.CellClick += dataGridView1_CellClick; 
            BooksTable.CellClick += dataGridView2_CellClick; 
        }

        private void update()
        {
            PicturesTable.Rows.Clear();
            BooksTable.Rows.Clear();
            int n = currPictures.Count;
            if(n > 0)
                PicturesTable.Rows.Add(n);
            for (int i = 0; i < n; ++i)
            {
                PicturesTable.Rows[i].Cells["Name"].Value = currPictures[i].GetName();
                PicturesTable.Rows[i].Cells["Author"].Value = currPictures[i].GetAuthor();
                PicturesTable.Rows[i].Cells["Price"].Value = currPictures[i].GetPrice();
                PicturesTable.Rows[i].Cells["Year"].Value = currPictures[i].GetYear();
                PicturesTable.Rows[i].Cells["Material"].Value = currPictures[i].GetMaterial();
            }
            n = currBooks.Count;
            if(n > 0)
                BooksTable.Rows.Add(n);
            for (int i = 0; i < n; ++i)
            {
                BooksTable.Rows[i].Cells["Name"].Value = currBooks[i].GetName();
                BooksTable.Rows[i].Cells["Author"].Value = currBooks[i].GetAuthor();
                BooksTable.Rows[i].Cells["Price"].Value = currBooks[i].GetPrice();
                BooksTable.Rows[i].Cells["Year"].Value = currBooks[i].GetYear();
                BooksTable.Rows[i].Cells["NumOfPage"].Value = currBooks[i].GetNumOfPages();
                BooksTable.Rows[i].Cells["Circulation"].Value = currBooks[i].GetCirculation();
            }
        }

        private void Form1_Load(object sender, EventArgs e)//Происходит при запуске приложения
        {
            PicturesTable.Columns.Clear();
            PicturesTable.ReadOnly = true;
            PicturesTable.AllowUserToAddRows = false;
            PicturesTable.AllowUserToDeleteRows = false;

            PicturesTable.Columns.Add("Name", "Название");
            PicturesTable.Columns.Add("Author", "Автор");
            PicturesTable.Columns.Add("Price", "Цена в 100$");
            PicturesTable.Columns.Add("Year", "Год создания");
            PicturesTable.Columns.Add("Material", "Материал");

            BooksTable.Columns.Clear();
            BooksTable.ReadOnly = true;
            BooksTable.AllowUserToAddRows = false;
            BooksTable.AllowUserToDeleteRows = false;

            BooksTable.Columns.Add("Name", "Название");
            BooksTable.Columns.Add("Author", "Автор");
            BooksTable.Columns.Add("Price", "Цена в $");
            BooksTable.Columns.Add("Year", "Год создания");
            BooksTable.Columns.Add("NumOfPage", "Кол-во стр");
            BooksTable.Columns.Add("Circulation", "Тираж");

            XmlDocument docPaTrains = new XmlDocument();
            docPaTrains.Load("C:\\Users\\Admin\\Desktop\\Документы_19_11_2024\\lab4\\" +
                "lab4\\pictures.xml");

            foreach (XmlNode node in docPaTrains.DocumentElement)
            {
                string name = node.Attributes[0].Value;
                string author = node["Author"].InnerText;
                int price = int.Parse(node["Price"].InnerText);
                int year = int.Parse(node["Year"].InnerText); 
                string material = node["Material"].InnerText;

                Picture curr = new Picture(name, author, price, year, material);
                Pictures.Add(curr);
                currPictures.Add(curr);
            }

            XmlDocument docFrTrains = new XmlDocument();
            docFrTrains.Load("C:\\Users\\Admin\\Desktop\\Документы_19_11_2024\\lab4" +
                "\\lab4\\books.xml");

            foreach (XmlNode node in docFrTrains.DocumentElement)
            {
                string name = node.Attributes[0].Value;
                string author = node["Author"].InnerText;
                int price = int.Parse(node["Price"].InnerText);
                int year = int.Parse(node["Year"].InnerText);
                int numOfPage = int.Parse(node["NumOfPage"].InnerText);
                int circulation = int.Parse(node["Circulation"].InnerText);

                Book curr = new Book(name, author, price, year, numOfPage, circulation);
                Books.Add(curr);
                currBooks.Add(curr);
            }

            Pictures.Sort();
            Books.Sort();
            update();
        }

        private void button1_Click(object sender, EventArgs e)//Обработка кнопки ДОБАВИТЬ
        {
            //Создание нового окна
            FormAdd f = new FormAdd();
            f.Owner = this;
            f.ShowDialog();
            
            update();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var currElem = PicturesTable.Rows[e.RowIndex];

                Picture curr = new Picture(currElem.Cells[0].Value.ToString(), 
                    currElem.Cells[1].Value.ToString(),
                    int.Parse(currElem.Cells[2].Value.ToString()),
                    int.Parse(currElem.Cells[3].Value.ToString()),
                    currElem.Cells[4].Value.ToString()
                    );
                FormPictureEditDel f = new FormPictureEditDel(curr);
                f.Owner = this;
                f.ShowDialog();
                update();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var currElem = BooksTable.Rows[e.RowIndex];
                Book curr = new Book(currElem.Cells[0].Value.ToString(),
                    currElem.Cells[1].Value.ToString(),
                    int.Parse(currElem.Cells[2].Value.ToString()),
                    int.Parse(currElem.Cells[3].Value.ToString()),
                    int.Parse(currElem.Cells[4].Value.ToString()),
                    int.Parse(currElem.Cells[5].Value.ToString())
                    );
                FormBookEditDel f = new FormBookEditDel(curr);
                f.Owner = this;
                f.ShowDialog();
                update();
            }
        }


        private void buttonPrimeDel_Click(object sender, EventArgs e)
        {
            FormPrimeDel f = new FormPrimeDel();
            f.Owner = this;
            f.ShowDialog();
            update();
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            FormFilter f = new FormFilter();
            f.Owner = this;
            f.ShowDialog();
            update();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (FormSort form6 = new FormSort())
            {
                if (form6.ShowDialog() == DialogResult.OK)
                {
                    string sortCriterion = form6.SortCriterion;
                    SortData(sortCriterion);
                    update();
                }
            }
        }

        private void SortData(string sortCriterion)
        {
            if (sortCriterion == "Name")
            {
                currPictures = currPictures.OrderBy(picture => picture.GetName()).ToList();
                currBooks = currBooks.OrderBy(book => book.GetName()).ToList();
            }
            else if (sortCriterion == "Author")
            {
                currPictures = currPictures.OrderBy(picture => picture.GetAuthor()).ToList();
                currBooks = currBooks.OrderBy(book => book.GetAuthor()).ToList();
            }
            else if (sortCriterion == "Price")
            {
                currPictures = currPictures.OrderBy(picture => picture.GetPrice()).ToList();
                currBooks = currBooks.OrderBy(book => book.GetPrice()).ToList();
            }
            else if (sortCriterion == "Year")
            {
                currPictures = currPictures.OrderBy(picture => picture.GetYear()).ToList();
                currBooks = currBooks.OrderBy(book => book.GetYear()).ToList();
            }
        }
    }

    public class Product : IComparable
    {
        private string name;
        private string author;
        private int year;
        private int price;

        public string GetName()
        { return name; }
        public void SetName(string value)
        { name = value; }

        public int GetYear()
        { return year; }
        public void SetYear(int value)
        { year = value; }

        public int GetPrice()
        { return price; }
        public void SetPrice(int value)
        { price = value; }

        public string GetAuthor()
        { return author; }
        public void SetAuthor(string value)
        { author = value; }


        public Product(string _name, string _author, int _price, int _year) 
        {
            name = _name;
            author = _author;
            price = _price;
            year = _year;
        }


        public int CompareTo(object o)
        {
            Product p = o as Product;
            if (p != null)
                return this.name.CompareTo(p.name);
            else
                throw new Exception("Невозможно сравнить два объекта");
        }
    }

    
    public class Picture : Product
    {
        private string material;  

        public void SetMaterial(string value)
        { material = value; }
        public string GetMaterial()
        { return material; }

        public Picture(string _name, string _author, int _price, int _year, string _material)
            : base(_name, _author, _price, _year)
        {
            material = _material; 
           
        }

    }

    
    public class Book : Product
    {
        private int numOfPages;
        private int circulation;

        public int GetNumOfPages()
        { return numOfPages; }
        public void SetNumOfPages(int value)
        { numOfPages = value; }

        public int GetCirculation()
        { return circulation; }
        public void SetCirculation(int value)
        { circulation = value; }

        public Book(string _name, string _author, int _price, int _year, 
            int _numOfPages, int _circulation)
            : base(_name, _author, _price, _year)
        {
            numOfPages = _numOfPages;
            circulation = _circulation;

        }
    }
}

