My keystone project for Code Louisville Software Development 2 is a mock e-commerce store using a Microsoft ASP.NET MVC web application that acts as a storefront for my dad's auction hobby. At this stage in the project, an administrator would be able perfrom CRUD operations on the products, as well as create a new category and edit the existing categories. My project meets the requirements by doing the following:
  * Creating lists in the product and category controller and retrieving values from that list
  * Having a generic repository interface that is implemented by a generic repository class
  * Adding comments to the category controller/product controller/ product repository by showing how my project implements SOLID programming principles
  * Making applicable methods in program asynchronous
My project uses Microsoft EntityFrameworkCore and SQLite as the data store. For the UI, I have elected to use Razor pages. Lastly, I used a repository pattern with this application to decouple higher level modules from lower ones as much as possible.
