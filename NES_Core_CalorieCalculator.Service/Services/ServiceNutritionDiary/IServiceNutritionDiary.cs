using NES_Core_CalorieCalculator.DAL.Context;
using NES_Core_CalorieCalculator.Service.Concretes.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NES_Core_CalorieCalculator.Service.Services.ServiceNutritionDiary
{
    public interface IServiceNutritionDiary
    {
        int Create(DTONutritionDiary model);
        int Update(DTONutritionDiary model);
        int Delete(DTONutritionDiary model);
        DTONutritionDiary GetById(int id);
        IList<DTONutritionDiary> GetAll();
        IList<DTONutritionDiary> GetAllActive();
        IList<DTONutritionDiary> GetByDate(DateTime date);
        IList<DTONutritionDiary> GetByDate(DateTime date, DTOUserInfo currentUserInfo);

        double GetTotalCaloriesByDay(DateTime date);
        double GetTotalCaloriesByDay(DateTime date, DTOUserInfo currentUserInfo);
        double GetTotalQuantityByDay(DateTime date);
        double GetTotalQuantityByDay(DateTime date, DTOUserInfo currentUserInfo);
        public IList<DTONutrientDiaryAnalysis> GetWeeklyAnalysisByMeal(int mealId);
        public IList<DTONutrientDiaryAnalysis> GetMonthlyAnalysisByMeal(int mealId);
        public IList<DTONutrientDiaryAnalysis> GetWeeklyAnalysisByNutrientCategory(int nutrientCategoryId);
        public IList<DTONutrientDiaryAnalysis> GetMonthlyAnalysisByNutrientCategory(int nutrientCategoryId);
        public IList<DTONutrientDiaryAnalysis> GetWeeklyAnalysisAverageByMeal(int mealId);
        public IList<DTONutrientDiaryAnalysis> GetMonthlyAnalysisAverageByMeal(int mealId);
        public IList<DTONutrientDiaryAnalysis> GetWeeklyAnalysisCurrentUserByMeal(int mealId, DTOUserInfo currentDTOUserInfo);
        public IList<DTONutrientDiaryAnalysis> GetMonthlyAnalysisurrentUserByMeal(int mealId, DTOUserInfo currentDTOUserInfo);
         
        IList<DTONutritionDiaryHistory> GetCurrentUserHistory(DTOUserInfo currentUserInfo);
    }
}
