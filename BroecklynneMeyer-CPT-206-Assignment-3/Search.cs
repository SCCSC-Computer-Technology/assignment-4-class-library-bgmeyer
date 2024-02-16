using BroecklynneMeyer_CPT_206_Assignment_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BroecklynneMeyer_CPT_206_Assignment_3
{
    public class Search
    {
        //search
        public IQueryable<State> SearchState(string criteria)//method to search state names
        { 
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          where state.StateID.Contains(criteria)
                          select state;
             return results;
        }

        public IQueryable<State> SearchPopulation(string criteria)//method to search population
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          where state.Population.Contains(criteria)
                          select state;
            return results;
        }

        public IQueryable<State> SearchFlower(string criteria)//method to search flower
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          where state.Flower.Contains(criteria)
                          select state;
            return results;
        }

        public IQueryable<State> SearchBird(string criteria)//method to search bird
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          where state.Bird.Contains(criteria)
                          select state;
            return results;
        }

        public IQueryable<State> SearchCapitol(string criteria)//method to search capitol
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          where state.Capitol.Contains(criteria)
                          select state;
            return results;
        }

        public IQueryable<State> SearchFlagDesc(string criteria)//method to search flag description
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          where state.FlagDescription.Contains(criteria)
                          select state;
            return results;
        }

        public IQueryable<State> SearchColor(string criteria)//method to search color
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          where state.Color.Contains(criteria)
                          select state;
            return results;
        }

        public IQueryable<State> SearchIncome(string criteria)//method to search income
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          where state.MedianIncome.Contains(criteria)
                          select state;
            return results;
        }

        public IQueryable<State> SearchJobs(string criteria)//method to search percent of comp jobs available
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          where state.ComputerRelatedJobs.Contains(criteria)
                          select state;
            return results;
        }

        public IQueryable<State> SearchLargCity(string criteria)//method to search largest city
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          where state.LargestCity.Contains(criteria)
                          select state;
            return results;
        }

        public IQueryable<State> SearchSecondLarg(string criteria)//method to search second largest city
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          where state.SecondLargestCity.Contains(criteria)
                          select state;
            return results;
        }

        public IQueryable<State> SearchThirdLarg(string criteria)//method to search third largest city
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          where state.ThirdLargestCity.Contains(criteria)
                          select state;
            return results;
        }

        //sort 
        public IQueryable<State> SortAscendStateID()//method to sort by state name asc
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          orderby state.StateID
                          select state;
            return results;
        }

        public IQueryable<State> SortDescStateID()//method to sort by state name desc
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          orderby state.StateID descending
                          select state;
            return results;
        }

        public IQueryable<State> SortAscendPopulation()//method to sort by population asc
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          orderby state.Population
                          select state;
            return results;
        }

        public IQueryable<State> SortDescPopulation()//method to sort by population desc
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          orderby state.Population descending
                          select state;
            return results;
        }

        public IQueryable<State> SortAscendFlower()//method to sort by flower asc
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          orderby state.Flower
                          select state;
            return results;
        }

        public IQueryable<State> SortDescFlower()//method to sort by flower desc
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          orderby state.Flower descending
                          select state;
            return results;
        }

        public IQueryable<State> SortAscendBird()//method to sort by bird asc
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          orderby state.Bird
                          select state;
            return results;
        }

        public IQueryable<State> SortDescBird()//method to sort by bird desc
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          orderby state.Bird descending
                          select state;
            return results;
        }

        public IQueryable<State> SortAscendCapitol()//method to sort by capitol asc
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          orderby state.Capitol
                          select state;
            return results;
        }

        public IQueryable<State> SortDescCapitol()//method to sort by capitol desc
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          orderby state.Capitol descending
                          select state;
            return results;
        }

        public IQueryable<State> SortAscendFlagDesc()//method to sort by flag description assc
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          orderby state.FlagDescription
                          select state;
            return results;
        }

        public IQueryable<State> SortDescFlagDesc()//method to sort by flag description desc
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          orderby state.FlagDescription descending
                          select state;
            return results;
        }

        public IQueryable<State> SortAscendColor()//method to sort by color asc
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          orderby state.Color
                          select state;
            return results;
        }

        public IQueryable<State> SortDescColor()//method to sort by color desc
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          orderby state.Color descending
                          select state;
            return results;
        }

        public IQueryable<State> SortAscendIncome()//method to sort by income asc
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          orderby state.MedianIncome
                          select state;
            return results;
        }

        public IQueryable<State> SortDescIncome()//method to sort by income desc
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          orderby state.MedianIncome descending
                          select state;
            return results;
        }

        public IQueryable<State> SortAscendJobs()//method to sort by jobs asc
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          orderby state.ComputerRelatedJobs
                          select state;
            return results;
        }

        public IQueryable<State> SortDescJobs()//method to sort by jobs desc
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          orderby state.ComputerRelatedJobs descending
                          select state;
            return results;
        }

        public IQueryable<State> SortAscendLargCity()//method to sort by largest city asc
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          orderby state.LargestCity
                          select state;
            return results;
        }

        public IQueryable<State> SortDescLargCity()//method to sort by largest city desc
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          orderby state.LargestCity descending
                          select state;
            return results;
        }

        public IQueryable<State> SortAscendSecondLarg()//method to sort by second largest city asc
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          orderby state.SecondLargestCity
                          select state;
            return results;
        }

        public IQueryable<State> SortDescSecondLarg()//method to sort by second largest city desc
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          orderby state.SecondLargestCity descending
                          select state;
            return results;
        }

        public IQueryable<State> SortAscendThirdLarg()//method to sort by third largest city asc
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          orderby state.ThirdLargestCity
                          select state;
            return results;
        }

        public IQueryable<State> SortDescendThirdLarg()//method to sort by third largest city desc
        {
            StatesDataContext db = new StatesDataContext();
            var results = from state in db.States
                          orderby state.ThirdLargestCity descending
                          select state;
            return results;
        }

       

        

       
    }
}
