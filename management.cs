using System;

public class Management{

    public void displayhigreviewProd(List<productreview> reviews){
        var record = (from productreview in reviews
                                    orderby productreview.rating descending
                                    select  new {productreview.productid,productreview.userid,productreview.rating}).Take(3);

        foreach (var review in record){
            Console.WriteLine("productid : {0} , userid: {1}, rating : {2}",review.productid,review.userid,review.rating);
        }
    }
}