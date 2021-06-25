using System;
using System.Collections.Generic;

namespace DogHero.API.Models
{
    public enum DogWalkingEnum{
        
        Started = 1,
        Finished = 2,
        Disabled = 3
        

    }
    public class DogWalking
    {
    public DogWalking(){

        this.Id = Guid.NewGuid();
        this.Status = DogWalkingEnum.Disabled;
        this.Pets = new List<Pets>();
        this.StartTime = new TimeSpan();
        this.EndTime = new TimeSpan();
       }

       public DogWalking(
           DateTime schedulingDate, 
           int duration, 
           Localization localization
           ) 
           : this(){
               
            this.SchedulingDate = schedulingDate;
            this.Duration = duration;
            this.Localization = localization;

            this.walkingCalc(duration);
        
       }

        public Guid Id { get; set; }
        public DateTime SchedulingDate { get; set; }
        public DogWalkingEnum Status { get; set; }
        public Localization Localization {get; set; }
        public int Duration { get; set; }
        public decimal Price { get; set;}
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime {get; set;}
        public ICollection<Pets> Pets {get; set;}
        private decimal AdditionalForPet {get; set;}

        public decimal TotalPriceWalking() => Price +(this.Pets.Count * AdditionalForPet);


        private void walkingCalc(int duration){

            switch (duration)
            {
                case 30:
                    this.Price = 25.0M;
                    this.AdditionalForPet = 15.0M;
                break;
                case 60 :
                    this.Price = 35.0M;
                    this.AdditionalForPet = 20.0M;
                break;
                default:
                    this.Price = 25.0M;
                    this.AdditionalForPet = 15.0M;
                break;
            }

        }

        public void StartWalk(){
            this.StartTime = TimeSpan.FromHours(DateTime.Now.Hour);
            
        }

        public void FinishWalk(){
            this.EndTime = TimeSpan.FromHours(DateTime.Now.Hour);
            this.Status = DogWalkingEnum.Finished;
        }

        public TimeSpan WalkTime(){
            return this.StartTime - this.EndTime;
        }

    }
}