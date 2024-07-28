using NES_Core_CalorieCalculator.DataCore.Concretes;
using NES_Core_CalorieCalculator.Service.Concretes.DTOs;
using NES_Core_CalorieCalculator.Service.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NES.WFA
{
    public partial class FormHome : Form
    {
        //User
        public DTOUserInfo currentUser;

        //Forms
        public FormAnimation formAnimation;
        public FormDiary formDiary;
        public FormHistory formHistory;
        public FormAnalysis formAnalysis;
        public FormAddNutrition formAddNutrition;
        public FormLogin formLogin;
        public FormSignUp formSignUp;

        //Service
        public ServiceAll serviceAll;

        //UI
        int colorCounter = 0;
        bool yon = true;

        public FormHome(ServiceAll _serviceAll)
        {
            InitializeComponent();
            serviceAll = _serviceAll;
        }


        public class custom
        {
            public int Dto1Id { get; set; }
            public string Dto1Name { get; set; }
            public int Dto2Id { get; set; }
            public string Dto2Surname { get; set; }
            public int Dto3Id { get; set; }
            public string Dto3Category { get; set; }
        }
        public class dto { public int Id { get; set; } public string Name { get; set; } }
        public class dto2 { public int Id { get; set; } public string Surname { get; set; } }
        public class dto3 { public int Id { get; set; } public string Category { get; set; } }

        public IList<dto> method(Expression<Func<dto, dto>> m, IList<dto> dtos)
        {
            IQueryable<dto> query = dtos.AsQueryable();
            var b = query.Select(x => new dto() { Id = x.Id });
            return query.Select(m).ToList();
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            IList<dto> dtos = new List<dto>();
            dto dto1 = new dto() { Id = 2, Name = "asd" };
            dto dto2 = new dto() { Id = 3, Name = "asd" };

            dtos.Add(dto1);
            dtos.Add(dto2);

            int toplam = 0;
            var result = dtos.Select(x => x.Id);

            var s = method(x => new dto() { Id = x.Id }, dtos);


            IList<dto> dtos1 = new List<dto>()
            {
                new dto() { Id=1,Name="dto1Name1"},
                new dto() { Id=2,Name="dto1Name2"},
            };
            IList<dto2> dtos2 = new List<dto2>()
            {
                new dto2() { Id=1,Surname="dto2Name1"},
                new dto2() { Id=2,Surname="dto2Name2"},
            };
            IList<dto3> dtos3 = new List<dto3>()
            {
                new dto3() { Id=1,Category="dto3Name1"},
                new dto3() { Id=2,Category="dto3Name2"},
            };


            var joined = dtos1.Join
                (
                    dtos2,
                    d1 => d1.Id,
                    d2 => d2.Id,
                    (d1, d2) => new
                    {
                        Id1 = d1.Id,
                        Id2 = d2.Id,
                        name = d1.Name,
                        surname = d2.Surname
                    }

                );

            IList<custom> myCustom = dtos1.Join
                (
                    dtos2,
                    d1 => d1.Id,
                    d2 => d2.Id,
                    (d1, d2) => new { d1, d2 }
                )
                .Join
                (
                    dtos3,
                    d12 => d12.d2.Id,
                    d3 => d3.Id,
                    (d12, d3) => new custom
                    {
                        Dto1Id = d12.d1.Id,
                        Dto1Name = d12.d1.Name,
                        Dto2Id = d12.d2.Id,
                        Dto2Surname = d12.d2.Surname,
                        Dto3Id = d3.Id,
                        Dto3Category = d3.Category,
                    }
                ).ToList();




            IList<DTONutritionDiary> dTONutritionDiaries = serviceAll.serviceNutritionDiary.GetAll();
            IList<DTONutrient> dTONutrients2 = serviceAll.serviceNutrient.GetAll();
            IList<DTONutrientCategory> dTONutrientCategories = serviceAll.serviceNutrientCategory.GetAll();


            IList<DTONutritionDiary> joinedDTONutritionDiary = dTONutritionDiaries.Join
                (
                    dTONutrients2,
                    nd => nd.NutrientId,
                    n => n.Id,
                    (nd, n) => new DTONutritionDiary()
                    {
                        NutrientCategoryId = n.NutrientCategoryId
                    }
                ).Join
                (
                    dTONutrientCategories,
                    nd => nd.NutrientCategoryId,
                    nc => nc.Id,
                    (nd, nc) => new DTONutritionDiary
                    {
                        NutrientCategoryId = nc.Id,
                    }
                ).ToList();

            //************************* buranın üstünü sil ******************************
            formDiary = new FormDiary(serviceAll);
            formDiary.MdiParent = this;
            formDiary.Dock = DockStyle.Fill;

            formHistory = new FormHistory(serviceAll);
            formHistory.MdiParent = this;
            formHistory.Dock = DockStyle.Fill;

            formAnalysis = new FormAnalysis(serviceAll);
            formAnalysis.MdiParent = this;
            formAnalysis.Dock = DockStyle.Fill;

            formAddNutrition = new FormAddNutrition(serviceAll);
            formAddNutrition.MdiParent = this;
            formAddNutrition.Dock = DockStyle.Fill;

            formAnimation = new FormAnimation(serviceAll, this);
            formAnimation.ShowDialog();

            formSignUp = new FormSignUp(serviceAll, this);



            IList<DTONutrient> dTONutrients = serviceAll.serviceNutrient.GetAll();

        }
        private void btnDiary_Click(object sender, EventArgs e)
        {
            OpenFormDiary();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            OpenFormHistory();
        }

        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            OpenFormAnalysis();
        }

        private void btnAddNutrion_Click(object sender, EventArgs e)
        {
            OpenFormAddNutrient();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            formDiary.Hide();
            formHistory.Hide();
            formAnalysis.Hide();
            formAddNutrition.Hide();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            formDiary.Hide();
            formHistory.Hide();
            formAnalysis.Hide();
            formAddNutrition.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (yon)
                colorCounter += 2;
            else colorCounter -= 2;

            if (colorCounter > 230)
                yon = false;
            if (colorCounter < 110)
                yon = true;

            Color color = Color.FromArgb(colorCounter, 0, 0);
            guna2CustomGradientPanel1.FillColor4 = color;
            guna2CustomGradientPanel2.FillColor2 = color;

            lblTime.Text = DateTime.Now.ToString("dd.MM.yyyy");
            lblTime2.Text = DateTime.Now.ToString("HH.mm.ss");
        }

        public void OpenFormDiary()
        {
            formDiary.Show();
            formHistory.Hide();
            formAnalysis.Hide();
            formAddNutrition.Hide();

            //refrest page before show
            formDiary.LoadNutrientListview();
            formDiary.RefreshMealsListviews();
        }

        public void OpenFormHistory()
        {
            formDiary.Hide();
            formHistory.Show();
            formAnalysis.Hide();
            formAddNutrition.Hide();

            //refrest page before show
            formHistory.RefreshAllListviews();
        }

        public void OpenFormAnalysis()
        {
            formDiary.Hide();
            formHistory.Hide();
            formAnalysis.Show();
            formAddNutrition.Hide();
        }

        public void OpenFormAddNutrient()
        {
            formDiary.Hide();
            formHistory.Hide();
            formAnalysis.Hide();
            formAddNutrition.Show();

            //refrest page before show
            formAddNutrition.RefreshNutrientListview();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formSignUp.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
