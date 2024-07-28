using NES_Core_CalorieCalculator.DAL.Context;
using NES_Core_CalorieCalculator.DAL.Interfaces;
using NES_Core_CalorieCalculator.DataCore.Concretes;
using NES_Core_CalorieCalculator.DataCore.Enums;
using NES_Core_CalorieCalculator.Service.Concretes.DTOs;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NES_Core_CalorieCalculator.Service.Services.ServiceNutritionDiary
{
    public class ServiceNutritionDiary : IServiceNutritionDiary
    {
        private readonly AppDbContext context;

        private readonly IRepoUserInfo repoUserInfo;
        private readonly IRepoNutritionDiary repoNutritionDiary;
        private readonly IRepoMeal repoMeal;
        private readonly IRepoNutrient repoNutrient;
        private readonly IRepoNutrientCategory repoNutrientCategory;

        public ServiceNutritionDiary
            (
                AppDbContext _context,
                IRepoUserInfo _repoUserInfo,
                IRepoNutritionDiary _repoNutritionDiary,
                IRepoMeal _repoMeal,
                IRepoNutrient _repoNutrient,
                IRepoNutrientCategory _repoNutrientCategory
            )
        {
            this.context = _context;
            this.repoUserInfo = _repoUserInfo;
            this.repoNutritionDiary = _repoNutritionDiary;
            this.repoMeal = _repoMeal;
            this.repoNutrient = _repoNutrient;
            this.repoNutrientCategory = _repoNutrientCategory;
        }
        public int Create(DTONutritionDiary model)
        {
            NutritionDiary createdNutritionDiary = new NutritionDiary();
            createdNutritionDiary.Date = model.Date;
            createdNutritionDiary.MealId = model.MealId;
            createdNutritionDiary.UserInfoId = model.UserInfoId;
            createdNutritionDiary.NutrientId = model.NutrientId;
            createdNutritionDiary.Quantity = model.Quantity;
            createdNutritionDiary.Calorie = model.Calorie;

            return repoNutritionDiary.Create(createdNutritionDiary);
        }
        public int Update(DTONutritionDiary model)
        {
            NutritionDiary updatedNutritionDiary = new NutritionDiary();
            updatedNutritionDiary.Date = model.Date;
            updatedNutritionDiary.UserInfoId = model.UserInfoId;
            updatedNutritionDiary.MealId = model.MealId;
            updatedNutritionDiary.Quantity = model.Quantity;
            updatedNutritionDiary.Calorie = model.Calorie;

            return repoNutritionDiary.Update(updatedNutritionDiary);
        }

        public int Delete(DTONutritionDiary model)
        {
            NutritionDiary deletedNutritionDiary = repoNutritionDiary.GetById(model.Id);
            return repoNutritionDiary.Delete(deletedNutritionDiary);
        }

        public IList<DTONutritionDiary> GetAll()
        {
            return (from nd in context.NutritionDiaries
                    join m in context.Meals on nd.MealId equals m.Id
                    join n in context.Nutrients on nd.NutrientId equals n.Id
                    join ui in context.UserInfos on nd.UserInfoId equals ui.Id
                    join nc in context.NutrientCategories on n.NutrientCategoryId equals nc.Id
                    select new DTONutritionDiary
                    {
                        Id = nd.Id,
                        Date = nd.Date,
                        UserInfoId = nd.UserInfoId,
                        MealId = nd.MealId,
                        NutrientId = nd.NutrientId,
                        Calorie = n.Calorie,
                        Quantity = nd.Quantity,
                        MealName = m.Name,
                        NutrientName = n.Name,
                        UserName = ui.Name,
                        NutrientCategoryName = nc.Name
                    }).ToList();
        }

        public IList<DTONutritionDiary> GetAllActive()
        {
            return (from nd in context.NutritionDiaries
                    join m in context.Meals on nd.MealId equals m.Id
                    join n in context.Nutrients on nd.NutrientId equals n.Id
                    join ui in context.UserInfos on nd.UserInfoId equals ui.Id
                    join nc in context.NutrientCategories on n.NutrientCategoryId equals nc.Id

                    where nd.Status != Status.Dropped
                    select new DTONutritionDiary
                    {
                        Id = nd.Id,
                        Date = nd.Date,
                        UserInfoId = nd.UserInfoId,
                        MealId = nd.MealId,
                        NutrientId = nd.NutrientId,
                        Calorie = n.Calorie,
                        Quantity = nd.Quantity,
                        MealName = m.Name,
                        NutrientName = n.Name,
                        UserName = ui.Name,
                        NutrientCategoryName = nc.Name
                    }).ToList();
        }

        public DTONutritionDiary GetById(int id)
        {
            NutritionDiary nutritionDiary = repoNutritionDiary.GetById(id);
            return new DTONutritionDiary
            {
                Id = nutritionDiary.Id,
                Date = nutritionDiary.Date,
                UserInfoId = nutritionDiary.UserInfoId,
                MealId = nutritionDiary.MealId
            };
        }

        public double GetTotalCaloriesByDay(DateTime date)
        {
            double totalCalories = 0;
            foreach (DTONutritionDiary item in GetByDate(date))
            {
                totalCalories += item.Calorie;
            }
            return totalCalories;
        }

        public double GetTotalCaloriesByDay(DateTime date, DTOUserInfo currentUserInfo)
        {
            double totalCalories = 0;
            foreach (DTONutritionDiary item in GetByDate(date, currentUserInfo))
            {
                totalCalories += item.Calorie;
            }
            return totalCalories;
        }

        /// <summary>
        /// Date format "Convert.ToDateTime("12.04.1996")"
        /// </summary>
        /// <param name="context"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public IList<DTONutritionDiary> GetByDate(DateTime date)
        {
            IList<DTONutritionDiary> diaryList = GetAll();
            return (from nd in context.NutritionDiaries
                    join m in context.Meals on nd.MealId equals m.Id
                    join n in context.Nutrients on nd.NutrientId equals n.Id
                    join ui in context.UserInfos on nd.UserInfoId equals ui.Id
                    join nc in context.NutrientCategories on n.NutrientCategoryId equals nc.Id

                    where nd.Date.Year == date.Year
                    where nd.Date.Month == date.Month
                    where nd.Date.Day == date.Day
                    where nd.Status != Status.Dropped
                    select new DTONutritionDiary
                    {
                        Id = nd.Id,
                        Date = nd.Date,
                        UserInfoId = nd.UserInfoId,
                        MealId = nd.MealId,
                        NutrientId = nd.NutrientId,
                        Calorie = nd.Calorie,
                        Quantity = nd.Quantity,
                        MealName = m.Name,
                        NutrientName = n.Name,
                        UserName = ui.Name,
                        NutrientCategoryName = nc.Name
                    }).ToList();
        }

        public IList<DTONutritionDiary> GetByDate(DateTime date, DTOUserInfo currentUserInfo)
        {
            IList<DTONutritionDiary> diaryList = GetAll();
            return (from nd in context.NutritionDiaries
                    join m in context.Meals on nd.MealId equals m.Id
                    join n in context.Nutrients on nd.NutrientId equals n.Id
                    join ui in context.UserInfos on nd.UserInfoId equals ui.Id
                    join nc in context.NutrientCategories on n.NutrientCategoryId equals nc.Id

                    where nd.Date.Year == date.Year
                    where nd.Date.Month == date.Month
                    where nd.Date.Day == date.Day
                    where nd.Status != Status.Dropped
                    where ui.Id == currentUserInfo.Id
                    select new DTONutritionDiary
                    {
                        Id = nd.Id,
                        Date = nd.Date,
                        UserInfoId = nd.UserInfoId,
                        MealId = nd.MealId,
                        NutrientId = nd.NutrientId,
                        Calorie = nd.Calorie,
                        Quantity = nd.Quantity,
                        MealName = m.Name,
                        NutrientName = n.Name,
                        UserName = ui.Name,
                        NutrientCategoryName = nc.Name
                    }).ToList();

        }

        public double GetTotalQuantityByDay(DateTime date)
        {
            double totalQuantity = 0;
            foreach (DTONutritionDiary item in GetByDate(date))
            {
                totalQuantity += item.Quantity;
            }
            return totalQuantity;

        }

        public double GetTotalQuantityByDay(DateTime date, DTOUserInfo currentUserInfo)
        {
            double totalQuantity = 0;
            foreach (DTONutritionDiary item in GetByDate(date, currentUserInfo))
            {
                totalQuantity += item.Quantity;
            }
            return totalQuantity;
        }

        public IList<DTONutrientDiaryAnalysis> GetWeeklyAnalysisByMeal(int mealId)
        {
            DateTime weekStartDate = DateTime.Now.AddDays(-7);
            DateTime weekEndDate = DateTime.Now;


            IList<DTONutritionDiary> LastWeekNutritionDiary =
            (from nd in context.NutritionDiaries
             join m in context.Meals on nd.MealId equals m.Id
             join n in context.Nutrients on nd.NutrientId equals n.Id
             join ui in context.UserInfos on nd.UserInfoId equals ui.Id
             join nc in context.NutrientCategories on n.NutrientCategoryId equals nc.Id

             where nd.Date > weekStartDate && nd.Date <= weekEndDate
             where nd.MealId == mealId
             where nd.Status != Status.Dropped


             select new DTONutritionDiary
             {
                 Id = nd.Id,
                 Date = nd.Date,
                 UserInfoId = nd.UserInfoId,
                 MealId = nd.MealId,
                 NutrientId = nd.NutrientId,
                 Calorie = nd.Calorie,
                 Quantity = nd.Quantity,
                 MealName = m.Name,
                 NutrientName = n.Name,
                 UserName = ui.Name,
                 NutrientCategoryName = nc.Name
             }).ToList();

            int activeUserCountLastWeek = LastWeekNutritionDiary.DistinctBy(x => x.UserInfoId).Count();


            IList<DTONutrientDiaryAnalysis> LastWeekNutritionDiaryAnalysis =
            LastWeekNutritionDiary
                .GroupBy(nutrientId => nutrientId.NutrientId)
                .Select
                (
                group => new DTONutrientDiaryAnalysis
                {
                    NutrientId = group.Key,
                    TotalConsumptionCalorie = group.Sum(nutrientId => nutrientId.Calorie),
                    TotalConsumptionQuantity = group.Sum(nutrientId => nutrientId.Quantity)
                })
                .OrderByDescending(x => x.TotalConsumptionCalorie)
                .ToList();

            foreach (DTONutrientDiaryAnalysis item in LastWeekNutritionDiaryAnalysis)
            {
                Nutrient nutrient = repoNutrient.GetById(item.NutrientId);

                item.NutrientName = nutrient.Name;
                item.NutrientCategoryId = nutrient.NutrientCategoryId;
                item.NutrientCategoryName = repoNutrientCategory.GetById(item.NutrientCategoryId).Name;
                item.AverageConsumptionCalorie = item.TotalConsumptionCalorie / activeUserCountLastWeek;
                item.AverageConsumptionQuantity = item.TotalConsumptionQuantity / activeUserCountLastWeek;
            }
            return LastWeekNutritionDiaryAnalysis;
        }

        public IList<DTONutrientDiaryAnalysis> GetMonthlyAnalysisByMeal(int mealId)
        {
            DateTime monthStartDate = DateTime.Now.AddDays(-30);
            DateTime monthEndDate = DateTime.Now;

            //gorupby 
            IList<DTONutritionDiary> LastMonthNutritionDiary =
            (from nd in context.NutritionDiaries
             join m in context.Meals on nd.MealId equals m.Id
             join n in context.Nutrients on nd.NutrientId equals n.Id
             join ui in context.UserInfos on nd.UserInfoId equals ui.Id
             join nc in context.NutrientCategories on n.NutrientCategoryId equals nc.Id

             where nd.Date > monthStartDate && nd.Date <= monthEndDate
             where nd.MealId == mealId
             where nd.Status != Status.Dropped


             select new DTONutritionDiary
             {
                 Id = nd.Id,
                 Date = nd.Date,
                 UserInfoId = nd.UserInfoId,
                 MealId = nd.MealId,
                 NutrientId = nd.NutrientId,
                 Calorie = nd.Calorie,
                 Quantity = nd.Quantity,
                 MealName = m.Name,
                 NutrientName = n.Name,
                 UserName = ui.Name,
                 NutrientCategoryName = nc.Name
             }).ToList();

            int activeUserCountLastMonth = LastMonthNutritionDiary.DistinctBy(x => x.UserInfoId).Count();


            IList<DTONutrientDiaryAnalysis> LastMonthNutritionDiaryAnalysis =
            LastMonthNutritionDiary
                .GroupBy(nutrientId => nutrientId.NutrientId)
                .Select
                (
                group => new DTONutrientDiaryAnalysis
                {
                    NutrientId = group.Key,
                    TotalConsumptionCalorie = group.Sum(nutrientId => nutrientId.Calorie),
                    TotalConsumptionQuantity = group.Sum(nutrientId => nutrientId.Quantity)
                })
                .OrderByDescending(x => x.TotalConsumptionCalorie)
                .ToList();

            foreach (DTONutrientDiaryAnalysis item in LastMonthNutritionDiaryAnalysis)
            {
                Nutrient nutrient = repoNutrient.GetById(item.NutrientId);

                item.NutrientName = nutrient.Name;
                item.NutrientCategoryId = nutrient.NutrientCategoryId;
                item.NutrientCategoryName = repoNutrientCategory.GetById(item.NutrientCategoryId).Name;
                item.AverageConsumptionCalorie = item.TotalConsumptionCalorie / activeUserCountLastMonth;
                item.AverageConsumptionQuantity = item.TotalConsumptionQuantity / activeUserCountLastMonth;
            }
            return LastMonthNutritionDiaryAnalysis;
        }

        public IList<DTONutrientDiaryAnalysis> GetWeeklyAnalysisByNutrientCategory(int nutrientCategoryId)
        {
            DateTime weekStartDate = DateTime.Now.AddDays(-7);
            DateTime weekEndDate = DateTime.Now;

            //gorupby 
            IList<DTONutritionDiary> LastWeekNutritionDiary =
            (from nd in context.NutritionDiaries
             join m in context.Meals on nd.MealId equals m.Id
             join n in context.Nutrients on nd.NutrientId equals n.Id
             join ui in context.UserInfos on nd.UserInfoId equals ui.Id
             join nc in context.NutrientCategories on n.NutrientCategoryId equals nc.Id

             where nd.Date > weekStartDate && nd.Date <= weekEndDate
             where n.NutrientCategoryId == nutrientCategoryId
             where nd.Status != Status.Dropped


             select new DTONutritionDiary
             {
                 Id = nd.Id,
                 Date = nd.Date,
                 UserInfoId = nd.UserInfoId,
                 MealId = nd.MealId,
                 NutrientId = nd.NutrientId,
                 Calorie = nd.Calorie,
                 Quantity = nd.Quantity,
                 MealName = m.Name,
                 NutrientName = n.Name,
                 UserName = ui.Name,
                 NutrientCategoryName = nc.Name,
                 NutrientCategoryId = n.NutrientCategoryId

             }).ToList();

            int activeUserCountLastWeek = LastWeekNutritionDiary.DistinctBy(x => x.UserInfoId).Count();


            IList<DTONutrientDiaryAnalysis> LastWeekNutritionDiaryAnalysis =
            LastWeekNutritionDiary
                .GroupBy(nutrientId => nutrientId.NutrientId)
                .Select
                (
                group => new DTONutrientDiaryAnalysis
                {
                    NutrientId = group.Key,
                    TotalConsumptionCalorie = group.Sum(nutrientId => nutrientId.Calorie),
                    TotalConsumptionQuantity = group.Sum(nutrientId => nutrientId.Quantity)
                })
                .OrderByDescending(x => x.TotalConsumptionCalorie)
                .ToList();

            foreach (DTONutrientDiaryAnalysis item in LastWeekNutritionDiaryAnalysis)
            {
                item.NutrientName = repoNutrient.GetById(item.NutrientId).Name;
                item.AverageConsumptionCalorie = item.TotalConsumptionCalorie / activeUserCountLastWeek;
                item.AverageConsumptionQuantity = item.TotalConsumptionQuantity / activeUserCountLastWeek;
            }
            return LastWeekNutritionDiaryAnalysis;
        }

        public IList<DTONutrientDiaryAnalysis> GetMonthlyAnalysisByNutrientCategory(int nutrientCategoryId)
        {
            DateTime monthStartDate = DateTime.Now.AddDays(-30);
            DateTime monthEndDate = DateTime.Now;

            //gorupby 
            IList<DTONutritionDiary> LastMonthNutritionDiary =
            (from nd in context.NutritionDiaries
             join m in context.Meals on nd.MealId equals m.Id
             join n in context.Nutrients on nd.NutrientId equals n.Id
             join ui in context.UserInfos on nd.UserInfoId equals ui.Id
             join nc in context.NutrientCategories on n.NutrientCategoryId equals nc.Id

             where nd.Date > monthStartDate && nd.Date <= monthEndDate
             where n.NutrientCategoryId == nutrientCategoryId
             where nd.Status != Status.Dropped


             select new DTONutritionDiary
             {
                 Id = nd.Id,
                 Date = nd.Date,
                 UserInfoId = nd.UserInfoId,
                 MealId = nd.MealId,
                 NutrientId = nd.NutrientId,
                 Calorie = nd.Calorie,
                 Quantity = nd.Quantity,
                 MealName = m.Name,
                 NutrientName = n.Name,
                 UserName = ui.Name,
                 NutrientCategoryName = nc.Name,
                 NutrientCategoryId = n.NutrientCategoryId

             }).ToList();

            int activeUserCountLastMonth = LastMonthNutritionDiary.DistinctBy(x => x.UserInfoId).Count();


            IList<DTONutrientDiaryAnalysis> LastMonthNutritionDiaryAnalysis =
            LastMonthNutritionDiary
                .GroupBy(nutrientId => nutrientId.NutrientId)
                .Select
                (
                group => new DTONutrientDiaryAnalysis
                {
                    NutrientId = group.Key,
                    TotalConsumptionCalorie = group.Sum(nutrientId => nutrientId.Calorie),
                    TotalConsumptionQuantity = group.Sum(nutrientId => nutrientId.Quantity)
                })
                .OrderByDescending(x => x.TotalConsumptionCalorie)
                .ToList();

            foreach (DTONutrientDiaryAnalysis item in LastMonthNutritionDiaryAnalysis)
            {
                item.NutrientName = repoNutrient.GetById(item.NutrientId).Name;
                item.AverageConsumptionCalorie = item.TotalConsumptionCalorie / activeUserCountLastMonth;
                item.AverageConsumptionQuantity = item.TotalConsumptionQuantity / activeUserCountLastMonth;
            }
            return LastMonthNutritionDiaryAnalysis;
        }

        public IList<DTONutritionDiaryHistory> GetCurrentUserHistory(DTOUserInfo currentUserInfo)
        {
            IList<DateTime> dates;
            DateTime startDate = Convert.ToDateTime("01.01.2024");
            dates = repoNutritionDiary
                .GetFilteredList
                (
                    select: x => x.Date,
                    where: x => x.Date > startDate && x.UserInfoId == currentUserInfo.Id
                ).Distinct().ToList();

            IList<DTONutritionDiaryHistory> history = new List<DTONutritionDiaryHistory>();
            foreach (DateTime date in dates)
            {
                history.Add(new DTONutritionDiaryHistory()
                {
                    Date = date,
                    UserInfoId = currentUserInfo.Id,
                    TotalCalorie = GetTotalCaloriesByDay(date, currentUserInfo),
                    TotalQuantity = GetTotalQuantityByDay(date, currentUserInfo)
                });
            }
            return history;
        }

        public IList<DTONutrientDiaryAnalysis> GetWeeklyAnalysisAverageByMeal(int mealId)
        {
            DateTime weekStartDate = DateTime.Now.AddDays(-7);
            DateTime weekEndDate = DateTime.Now;

            IList<DTONutritionDiary> LastWeekNutritionDiary;

            if (mealId == 5)//select all meals
            {
                LastWeekNutritionDiary =
            (from nd in context.NutritionDiaries
             join m in context.Meals on nd.MealId equals m.Id
             join n in context.Nutrients on nd.NutrientId equals n.Id
             join ui in context.UserInfos on nd.UserInfoId equals ui.Id
             join nc in context.NutrientCategories on n.NutrientCategoryId equals nc.Id

             where nd.Date > weekStartDate && nd.Date <= weekEndDate
             where nd.Status != Status.Dropped

             select new DTONutritionDiary
             {
                 Id = nd.Id,
                 Date = nd.Date,
                 UserInfoId = nd.UserInfoId,
                 MealId = nd.MealId,
                 NutrientId = nd.NutrientId,
                 Calorie = nd.Calorie,
                 Quantity = nd.Quantity,
                 MealName = m.Name,
                 NutrientName = n.Name,
                 UserName = ui.Name,
                 NutrientCategoryName = nc.Name,
                 NutrientCategoryId = n.NutrientCategoryId

             }).ToList();
            }
            else
            {
                LastWeekNutritionDiary =
           (from nd in context.NutritionDiaries
            join m in context.Meals on nd.MealId equals m.Id
            join n in context.Nutrients on nd.NutrientId equals n.Id
            join ui in context.UserInfos on nd.UserInfoId equals ui.Id
            join nc in context.NutrientCategories on n.NutrientCategoryId equals nc.Id

            where nd.Date > weekStartDate && nd.Date <= weekEndDate
            where nd.MealId == mealId
            where nd.Status != Status.Dropped


            select new DTONutritionDiary
            {
                Id = nd.Id,
                Date = nd.Date,
                UserInfoId = nd.UserInfoId,
                MealId = nd.MealId,
                NutrientId = nd.NutrientId,
                Calorie = nd.Calorie,
                Quantity = nd.Quantity,
                MealName = m.Name,
                NutrientName = n.Name,
                UserName = ui.Name,
                NutrientCategoryName = nc.Name,
                NutrientCategoryId = n.NutrientCategoryId

            }).ToList();
            }

            //Gets active users for last week
            int activeUserCountLastWeek = LastWeekNutritionDiary.DistinctBy(x => x.UserInfoId).Count();

            IList<DTONutrientDiaryAnalysis> LastWeekNutritionDiaryAnalysis =
            LastWeekNutritionDiary
                .GroupBy(nutrientId => nutrientId.NutrientId)
                .Select
                (
                group => new DTONutrientDiaryAnalysis
                {
                    NutrientId = group.Key,
                    TotalConsumptionCalorie = group.Sum(nutrientId => nutrientId.Calorie),
                    TotalConsumptionQuantity = group.Sum(nutrientId => nutrientId.Quantity)
                }).ToList();


            foreach (DTONutrientDiaryAnalysis item in LastWeekNutritionDiaryAnalysis)
            {
                Nutrient nutrient = repoNutrient.GetById(item.NutrientId);

                item.AverageConsumptionCalorie = item.TotalConsumptionCalorie / activeUserCountLastWeek;
                item.AverageConsumptionQuantity = item.TotalConsumptionQuantity / activeUserCountLastWeek;
                item.NutrientName = nutrient.Name;
                item.NutrientCategoryId = nutrient.NutrientCategoryId;
                item.NutrientCategoryName = repoNutrientCategory.GetById(item.NutrientCategoryId).Name;
            }
            return LastWeekNutritionDiaryAnalysis;
        }

        public IList<DTONutrientDiaryAnalysis> GetMonthlyAnalysisAverageByMeal(int mealId)
        {
            throw new NotImplementedException();
        }

        public IList<DTONutrientDiaryAnalysis> GetWeeklyAnalysisCurrentUserByMeal(int mealId, DTOUserInfo currentDTOUserInfo)
        {
            DateTime weekStartDate = DateTime.Now.AddDays(-7);
            DateTime weekEndDate = DateTime.Now;


            IList<DTONutritionDiary> LastWeekNutritionDiary;

            if (mealId == 5)//select all meals
            {
                LastWeekNutritionDiary =
            (from nd in context.NutritionDiaries
             join m in context.Meals on nd.MealId equals m.Id
             join n in context.Nutrients on nd.NutrientId equals n.Id
             join ui in context.UserInfos on nd.UserInfoId equals ui.Id
             join nc in context.NutrientCategories on n.NutrientCategoryId equals nc.Id

             where nd.UserInfoId == currentDTOUserInfo.Id
             where nd.Date > weekStartDate && nd.Date <= weekEndDate
             where nd.Status != Status.Dropped

             select new DTONutritionDiary
             {
                 Id = nd.Id,
                 Date = nd.Date,
                 UserInfoId = nd.UserInfoId,
                 MealId = nd.MealId,
                 NutrientId = nd.NutrientId,
                 Calorie = nd.Calorie,
                 Quantity = nd.Quantity,
                 MealName = m.Name,
                 NutrientName = n.Name,
                 UserName = ui.Name,
                 NutrientCategoryName = nc.Name,
                 NutrientCategoryId = n.NutrientCategoryId

             }).ToList();
            }
            else
            {
                LastWeekNutritionDiary =
           (from nd in context.NutritionDiaries
            join m in context.Meals on nd.MealId equals m.Id
            join n in context.Nutrients on nd.NutrientId equals n.Id
            join ui in context.UserInfos on nd.UserInfoId equals ui.Id
            join nc in context.NutrientCategories on n.NutrientCategoryId equals nc.Id

            where nd.UserInfoId == currentDTOUserInfo.Id
            where nd.Date > weekStartDate && nd.Date <= weekEndDate
            where nd.MealId == mealId
            where nd.Status != Status.Dropped

            select new DTONutritionDiary
            {
                Id = nd.Id,
                Date = nd.Date,
                UserInfoId = nd.UserInfoId,
                MealId = nd.MealId,
                NutrientId = nd.NutrientId,
                Calorie = nd.Calorie,
                Quantity = nd.Quantity,
                MealName = m.Name,
                NutrientName = n.Name,
                UserName = ui.Name,
                NutrientCategoryName = nc.Name,
                NutrientCategoryId = n.NutrientCategoryId

            }).ToList();
            }

            IList<DTONutrientDiaryAnalysis> LastWeekNutritionDiaryAnalysis =
            LastWeekNutritionDiary
                .GroupBy(nutrientId => nutrientId.NutrientId)
                .Select
                (
                group => new DTONutrientDiaryAnalysis
                {
                    NutrientId = group.Key,
                    TotalConsumptionCalorie = group.Sum(nutrientId => nutrientId.Calorie),
                    TotalConsumptionQuantity = group.Sum(nutrientId => nutrientId.Quantity)
                }).ToList();


            foreach (DTONutrientDiaryAnalysis item in LastWeekNutritionDiaryAnalysis)
            {
                Nutrient nutrient = repoNutrient.GetById(item.NutrientId);

                item.NutrientName = nutrient.Name;
                item.NutrientCategoryId = nutrient.NutrientCategoryId;
                item.NutrientCategoryName = repoNutrientCategory.GetById(item.NutrientCategoryId).Name;
            }
            return LastWeekNutritionDiaryAnalysis;
        }


        public IList<DTONutrientDiaryAnalysis> GetMonthlyAnalysisurrentUserByMeal(int mealId, DTOUserInfo currentDTOUserInfo)
        {
            throw new NotImplementedException();
        }
    }
}
