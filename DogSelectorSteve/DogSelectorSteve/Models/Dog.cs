using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DogSelectorSteve.Models
{
    public enum EScale
    {
        High = 0, Medium, Low, noPref
    }

    public enum ELength
    {
        Long = 0, Medium, Short, noPref
    }

    public enum ESize
    {
        Giant = 0, Large, Medium, Small, Miniature, noPref
    }

    public class Dog
    {
       //variables 
        public String BreedName { get; set; }

        
        public String DisplayName { get; set; }
        
        
        public String ImageName { get; set; }
        
        
        public EScale ActivityLevel { get; set; }
        
        
        public EScale GroomingLevel { get; set; }
        
        
        public EScale IntelligenceLevel { get; set; }
        
        
        public EScale SheddingLevel { get; set; }
        
        
        public ESize Size { get; set; }
        
        
        public ELength Coatlength { get; set; }
        
        
        public bool Drools { get; set; }
        
        
        public bool GoodWithChildren { get; set; }


        

    }
}
