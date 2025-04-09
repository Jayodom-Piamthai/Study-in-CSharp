using ContosoPizza.Data;
using ContosoPizza.Models;
using ContosoPizza.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ContosoPizza.Controllers;

[ApiController]
//set route name,[controller] part will be replace by controller name + input 
//this file PizzaController then would result in route named /Pizza
[Route("[controller]")]
public class PizzaController(PizzaContext context) : ControllerBase
{
    //public PizzaController()
    //{
    //}

    //pizza context for entity ORM
    private readonly PizzaContext _context= context;


    [HttpGet ("getAll")]
    public async Task<ActionResult<List<Pizza>>> GetAllPizza()
    {
        return Ok(await _context.SetPizza.ToListAsync());
    }

    [HttpGet("getPizza/{id}")]
    public async Task<ActionResult<List<Pizza>>> GetPizza(int id)
    {
        var FoundPizza = await _context.SetPizza.FindAsync(id);
        if (FoundPizza == null) 
            return NotFound();
        return Ok(FoundPizza);
    }

    [HttpPost("newPizza")]
    public async Task<ActionResult<List<Pizza>>> NewPizza(Pizza newPizza)
    {
        if(newPizza == null) 
            return BadRequest();
        _context.SetPizza.Add(newPizza);
        //wait til change is confirmed to respond
        await _context.SaveChangesAsync();
        //return result with name of new pizza gotten via Getpizza from Get API above
        return CreatedAtAction(nameof(GetPizza), new {id =  newPizza.Id}, newPizza);  

    }

    [HttpPut("UpdatePizza/{id}")]
    public async Task<ActionResult<List<Pizza>>> UpdatePizza(int id , Pizza UpdatePizza)
    {
        var FoundPizza = await _context.SetPizza.FindAsync(id);
        if (FoundPizza == null)
            return NotFound();

        FoundPizza.Id = UpdatePizza.Id; 
        FoundPizza.Name = UpdatePizza.Name; 
        FoundPizza.IsGlutenFree = UpdatePizza.IsGlutenFree;

        await _context.SaveChangesAsync();

        //return Ok(FoundPizza);
        var AllPizza = await _context.SetPizza.ToListAsync();
        return Ok(AllPizza);
    }

    [HttpDelete("RemovePizza")]
    public async Task<ActionResult<List<Pizza>>> RemovePizza(int id)
    {
        var FoundPizza = await _context.SetPizza.FindAsync(id);
        if (FoundPizza == null)
            return NotFound();
        _context.SetPizza.Remove(FoundPizza);
        //wait til change is confirmed to respond
        await _context.SaveChangesAsync();
        //return result with name of new pizza gotten via Getpizza from Get API above
        var AllPizza = await _context.SetPizza.ToListAsync(); //await query into db so it neet to be later right here
        return Ok(AllPizza);

    }

    // GET all action
    [HttpGet]
    public ActionResult<List<Pizza>> GetAll() =>
         PizzaService.GetAll();

    // GET by Id action
    [HttpGet("{id}")]
    public ActionResult<Pizza> Get(int id)
    {
        var pizza = PizzaService.Get(id);

        if(pizza == null)
            return NotFound();

        //return status 200 and pizza data
        return Ok(pizza);
        //return  pizza;
    }

    // POST action
    [HttpPost]
    //IActionResult lets the client know if the request succeeded and provides the ID of the newly created pizza. 
    //Iaction` used for when unsure of result filetype - in this case: if result is success or failure 
    public IActionResult Create(Pizza pizza)
    {            
        PizzaService.Add(pizza);
        return CreatedAtAction(nameof(Get), new { id = pizza.Id }, pizza);
    }

    // PUT action
   [HttpPut("{id}")]
    public IActionResult Update(int id, Pizza pizza)
    {
        if (id != pizza.Id)
            return BadRequest();
            
        var existingPizza = PizzaService.Get(id);
        if(existingPizza is null)
            return NotFound();
    
        PizzaService.Update(pizza);           
    
        return NoContent();
    }  
    // DELETE action
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var pizza = PizzaService.Get(id);
    
        if (pizza is null)
            return NotFound();
        
        PizzaService.Delete(id);
    
        return NoContent();
    }
}