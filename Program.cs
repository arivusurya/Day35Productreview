using System;
using System.Data;
using System.Collections;
using System.Text;


public class Program{
    public static void Main(string[] args)
    {
        List<productreview> productreviews = new List<productreview>(){
            new productreview(){productid=1,userid=1,rating=5,review="good",islike=true},
            new productreview(){productid=3,userid=2,rating=4,review="good",islike=true},
            new productreview(){productid=4,userid=3,rating=3,review="it was ok",islike=false},
            new productreview(){productid=10,userid=4,rating=5,review="good",islike=true},
            new productreview(){productid=12,userid=6,rating=4,review="good",islike=true},
            new productreview(){productid=14,userid=8,rating=3,review="it was ok",islike=false},
            new productreview(){productid=1,userid=12,rating=1,review="worst",islike=false},
            new productreview(){productid=1,userid=14,rating=4,review="good",islike=true},
            new productreview(){productid=1,userid=18,rating=2,review="not good",islike=false},
            new productreview(){productid=1,userid=12,rating=5,review="good",islike=true},
            new productreview(){productid=5,userid=2,rating=5,review="good",islike=true},
            new productreview(){productid=6,userid=11,rating=3,review="It was ok",islike=false},
            new productreview(){productid=7,userid=13,rating=4,review="good",islike=true},
            new productreview(){productid=4,userid=1,rating=2,review="Not good",islike=false},

        };
        Management management = new Management();
        management.displayhigreviewProd(productreviews);
    }
}
