using BLL.Configuration;
using BLL.ServiceInterfaces;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using winFormsUI;

namespace lab_1
{
    public partial class MainForm : Form
    {
        // �������
        private Dictionary<string, IPassengerRepository> currPassengersRep = new();
        private Dictionary<string, ITicketRepository> currTicketRep = new();
        private Dictionary<string, ITrainRepository> currTrainRep = new();
        public string currentKey { get; set; }

        public MainForm()
        {
            InitializeComponent();
            menuStrip1.Visible = false;
            string passengerFile = ConfigurationManager.ConnectionStrings["passengerFile"].ConnectionString;
            //string ticketFile = ConfigurationManager.ConnectionStrings["ticketFile"].ConnectionString;
            //string trainFile = ConfigurationManager.ConnectionStrings["trainFile"].ConnectionString;
            //string connectionString = ConfigurationManager.ConnectionStrings["RailwayTicketingDB"].ConnectionString;





            // ���������� � ios ���������
            //var builder = new DbContextOptionsBuilder<DAL.EF.ApplicationContext>();
            //DbContextOptions<DAL.EF.ApplicationContext> options = builder.UseSqlServer(connectionString).Options;
            //DAL.EF.ApplicationContext db = new DAL.EF.ApplicationContext(options);

            string efConnectionString = ConfigurationManager.ConnectionStrings["RailwayTicketingEF"].ConnectionString;
            var services = new ServiceCollection();
            //services.ConfigureDAL(efConnectionString);
            services.ConfigureBLL(efConnectionString);


            //services.ConfigureEfServices(); // ����� ���������� ����������� (���������) ��� ef
            services.ConfigureFileServices(passengerFile); // ����� ���������� ����������� (���������) ��� csv ������


            // ������ ��������� ��������
            using (var serviceProvider = services.BuildServiceProvider())
            {
                //var passengerRepository = serviceProvider.GetService<IPassengerRepository>(); // �������� PassengerRepository
                //var trainRepository = serviceProvider.GetService<ITrainRepository>(); // �������� PassengerRepository

                var passenserService = serviceProvider.GetService<IPassengerService>(); // ������� ������ ��� ������ � �����������


                dataGridView1.DataSource = passenserService.GetAll();
            }




            //// ���������
            //currPassengersRep.Add("db", new DAL.DBRepositories.PassengerRepository(connectionString));
            //currPassengersRep.Add("csv", new DAL.CSVRepositories.PassengerRepository(passengerFile));

            //// ������
            //currTicketRep.Add("db", new DAL.DBRepositories.TicketRepository(connectionString));
            //currTicketRep.Add("csv", new DAL.CSVRepositories.TicketRepository(ticketFile));

            //// ������
            //currTrainRep.Add("db", new DAL.DBRepositories.TrainRepository(connectionString));
            //currTrainRep.Add("csv", new DAL.CSVRepositories.TrainRepository(trainFile));

            ////ef
            ////currTrainRep.Add("ef", new DAL.EFRepositories.PassengerRepository());
            ////currTrainRep.Add("csv", new DAL.CSVRepositories.TrainRepository(trainFile));

            //comboBox1.Items.Add("csv");
            //comboBox1.Items.Add("db");
            ////comboBox1.Items.Add("ef");
        }


        // �������� csv, db
        private void ���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = currPassengersRep[currentKey].GetAll();
        }

        private void ������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = currTicketRep[currentKey].GetAll();
        }

        private void ������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = currTrainRep[currentKey].GetAll();
        }


        // ���������� csv, db
        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var passengerToAdd = new Passenger { Id = currPassengersRep[currentKey].GetAll().Count() + 1, FirstName = "Nikolai", SecondName = "Vorchun", PassportData = "HB2314211", Phone = "+375294729248" };
            AddForm addForm = new AddForm();
            addForm.startTabInd = 0;

            if (addForm.ShowDialog() == DialogResult.OK)
            {
                var passengerToAdd = addForm.passToAdd;
                passengerToAdd.Id = currPassengersRep[currentKey].GetAll().ToList().LastOrDefault().Id + 1;
                currPassengersRep[currentKey].Add(passengerToAdd);
                MessageBox.Show("�������� ��������.");
            }
        }

        private void ������ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //var ticketToAdd = new Ticket { Id = currTicketRep[currentKey].GetAll().Count() + 1, Source = "Almati", Destination = "Kirov", StartTime = DateTime.Parse("2024-10-08 01:50"), ArrivalTime = DateTime.Parse("2024-10-09 11:30"), WagonNumber = 3, PlaceNumber = 4 
            AddForm addFrom = new AddForm();
            addFrom.startTabInd = 1;
            if (addFrom.ShowDialog() == DialogResult.OK)
            {
                var ticketToAdd = addFrom.ticketToAdd;
                ticketToAdd.Id = currTicketRep[currentKey].GetAll().ToList().LastOrDefault().Id + 1;
                currTicketRep[currentKey].Add(ticketToAdd);
                MessageBox.Show("����� ��������.");
            }
        }

        private void ������ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //var trainToAdd = new Train { Id = lastTrainId + 1, Route = "Gomel - Praga", Capacity = 80, WagonCount = 50 };
            AddForm addForm = new AddForm();
            addForm.startTabInd = 2;
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                var trainToAdd = addForm.trainToAdd;
                trainToAdd.Id = currTrainRep[currentKey].GetAll().ToList().LastOrDefault().Id + 1;
                currTrainRep[currentKey].Add(trainToAdd);
                MessageBox.Show("����� ��������.");
            }
        }

        // �������� csv, db
        private void ���������ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteForm deleteForm = new DeleteForm(currPassengersRep[currentKey].GetAll().Select(p => p.Id).ToList());
            if (deleteForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    currPassengersRep[currentKey].Delete(currPassengersRep[currentKey].Get(deleteForm.indToDelete));
                    MessageBox.Show("�������� ������");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ������ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DeleteForm deleteForm = new DeleteForm(currTicketRep[currentKey].GetAll().Select(p => p.Id).ToList());
            if (deleteForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    currTicketRep[currentKey].Delete(currTicketRep[currentKey].Get(deleteForm.indToDelete));
                    MessageBox.Show("����� ������");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ������ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteForm deleteForm = new DeleteForm(currTrainRep[currentKey].GetAll().Select(p => p.Id).ToList());
            if (deleteForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    currTrainRep[currentKey].Delete(currTrainRep[currentKey].Get(deleteForm.indToDelete));
                    MessageBox.Show("����� ������");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // ����� � csv � � ��
        private void ���������ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            if (searchForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Passenger passenger = currPassengersRep[currentKey].Get(searchForm.indToReturn);
                    MessageBox.Show($"��������: {passenger.Id}, {passenger.FirstName}, {passenger.SecondName}, {passenger.Phone}, {passenger.PassportData}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ������ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            if (searchForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Ticket ticket = currTicketRep[currentKey].Get(searchForm.indToReturn);
                    MessageBox.Show($"�����: {ticket.Id}, {ticket.Source}, {ticket.Destination}, {ticket.StartTime}, {ticket.ArrivalTime}, {ticket.WagonNumber}, {ticket.PlaceNumber}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ������ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            if (searchForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Train train = currTrainRep[currentKey].Get(searchForm.indToReturn);
                    MessageBox.Show($"�����: {train.Id}, {train.Route}, {train.Capacity}, {train.WagonCount}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // ��������� ��������� ������
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (menuStrip1.Visible == false) menuStrip1.Visible = true;
            currentKey = comboBox1.SelectedItem.ToString();
        }
    }
}
