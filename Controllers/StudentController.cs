
using System;
using Microsoft.AspNetCore.Mvc;

namespace StudentController.StudentController
{
    public class StudentController : Controller
        {
            public IActionResult Index()
            {
                return View();
            }

            [HttpPost]
            public IActionResult Index(string canhA, string canhB, string canhC)
            {
                double tong,A, B, C, a =0, b =0, c =0;
                string ketqua;

                if(!String.IsNullOrEmpty(canhA)) a = Convert.ToDouble(canhA);
                if(!String.IsNullOrEmpty(canhB)) b = Convert.ToDouble(canhB);
                if(!String.IsNullOrEmpty(canhC)) c = Convert.ToDouble(canhC);

                if(a ==0 || b == 0 || c ==0){
                    ketqua = "Không phải tam giác";
                }
                else{
                    A = Math.Pow(b,2) + Math.Pow(c,2);
                    B = Math.Pow(a,2) + Math.Pow(c,2);
                    C = Math.Pow(b,2) + Math.Pow(a,2);
                    tong = a+b;

                    if(tong <=c){
                        ketqua="Đây không phải tam giác";
                    }

                    else if(Math.Pow(a,2)==A || Math.Pow(b,2)==B || Math.Pow(c,2)==C )
                    {
                        ketqua= "Đây là tam giác vuông";
                    }
                    
                    else if( a ==b && b == c && c == a){
                        ketqua= "Đây là tam giác đều";
                    }
                    else if( a ==b || b == c || c == a){
                        ketqua= "Đây là tam giác cân";
                    }
                    else if( Math.Pow(a,2) + Math.Pow(b,2) >Math.Pow(c,2)  ){
                        ketqua= "Đây là tam giác nhọn";
                    }
                    else if( Math.Pow(a,2) + Math.Pow(b,2) < Math.Pow(c,2)  ){
                        ketqua= "Đây là tam giác tù";
                    }
                    
                    else{
                        ketqua = "Đây là tam giác thường";
                    }

                }

                ViewBag.thongbao = ketqua;
                return View();
            }
        }
}