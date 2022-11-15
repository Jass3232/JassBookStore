2022-20-10

rAZOR Runtime enable
prperties launch setting //
check packages 

lets push to github

removed the options flag in startup.cs
  //"sslPort": 44389 comment out only lab launchsetting.json

  commit done 
  Date 2022-11-01
 
 i added  bootstrap and commit and push but unfortunately it didnt added on github
 so im doing whole procees again
 one weird thing i saw additional boostrap files in my css folder
 then i delete additional files
  Now theme applied from bootswatch.com with changes done on files layout.cshtml and login partial.cshtml

  additional stylesheets added
  Additional script- files added

   Date 2022-11-03 
   now added dropdown    
  and remove bs from  "data-bs-toggle" 
  "data-toggle" this works perfects before that it nt working

  site.css changed with given class site.css file
  Now working perfect everything
  now time to commit


  Date 2022-11-03
  in the first attempt i got errors because i reinstall the sql server nu pacakge
  then i didnt commit 
  deleted everything

   then started again

  Added 3 projects

  nugets packages installed

  Relational and Entity frameworkcore only because sql server already in.
  commit done

  date 08-11-2022  1:53 Am

  I select ASP.net empty to make 3 projects which is wrong selecion
  so then i  delete old ones and start with new 3 projects  with class "library" to make new

  added projects 
   Relational and Entity frameworkcore only because sql server already in.
  commit done
  again
  
  project references done
  sd.cs added

  11/08/2022 11:02am

  using JassBookStore.Models.ViewModels; is missing in homecontroller thats why it build falied
  now running smooth
  Add > Areas> Customer   done
  path specified for controller and view ,home and moved into areas customer done
  Add > Areas> Admin   done
  upload git


  11/13/2022 11:02pm
   

 run  Command add-migration AddDefaultIdentityMigration. Succeeded. 
 
 File name: 20221111194841_AddDefaultIdentityMigration.cs created

 then Update-Database Command

 create a file name Category.cs in Models.

  Add Category into DBContext file. TODO: run command add-migration AddCategoryToDb and update-database

  11/14/2022 1:02AM


  Part 2.2
Add Repository folder and subfolder IRepository

 Finaly Added  and modify CategoryRepository.cs and ICategoryRepository.cs



 Add update method in CategoryRepository.cs

 Create ISP_Call file and install Dapper package

 11/14/2022 1:00PM
 Modified ISP_Call.cs

 Modified SP_Call.cs, 

 
 create IUnitOfWork and UnitOfWork

 11/15/2022 1:02AM
 Part 2.3 Category CRUD added
 I added services.AddScoped<IUnitOfWork, UnitOfWork>(); in the startup.cs file

 Added new MVC Controller in Area/Admin and gave it name of CategoryController.cs
 Then I added a Area/View folder and inside it I added Index.cshtml file
 In -Layout.cshtml file, move the 'Category' link to the Content management drop down.Now its showing in the drop list of it
 Modified the index.cshtml  inorder to add the icons

 Remove this code from given file and added it to the given javascript file

 To perform CRUD operation, added the Upsert.cshtml file,copied given code in it,modified it
 In the Index.cshtml file added the asp-action where its required


 Add  view for CreateAndBacktoListButton 

 Add view for EditAndBacktoListButton

 Remove the _db.SaveChanges from the CategoryRepository.cs file and move the _unitOfWork.Save() method with the return RedirectToaction method. 

 To perform delete operation Add the delete functionality in category.js 
Add the Delete(url) functioncode 
