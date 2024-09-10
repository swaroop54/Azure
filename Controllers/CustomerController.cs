using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvc4.Models;
using mvc4.Data;

namespace mvc4.Controllers;

public class CustomerController : Controller
{
    CustomerDbContext cdb=new CustomerDbContext();
    public IActionResult Index()
    {
       return View();
    }
    public IActionResult Create(){
        return View();

    }
    public IActionResult Updatedetails(){
        return View();
    }
    public IActionResult Add_Details(Customer c){
        
        cdb.Customers.Add(c);
        cdb.SaveChanges();
        return RedirectToAction("Index");
    }
    public IActionResult Retrieve(){
        var res=cdb.Customers.ToList();
        return View(res);
    }
    
    public IActionResult Edit(Customer c){
        Customer res=cdb.Customers.Find(c.Id);
        if(res==null){
            return Content("<center><u><h1>Id Not Found</h1></u></center>","text/html");
        }
        res.Orders=c.Orders;
        cdb.SaveChanges();
        return RedirectToAction("Retrieve");
    }
    public IActionResult Delete(){
        return View();
    }
    public IActionResult Delete_Details(Customer c){
        Customer res=cdb.Customers.Find(c.Id);
        if(res!=null){
            cdb.Remove(res);
            cdb.SaveChanges();
            return RedirectToAction("Retrieve");
        }
        return Content("<center><u><h1>Id Not Found</h1></u></center>","text/html");
        
    }

} 