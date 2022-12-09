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

  date 2022/11/08 1:53 Am

  I select ASP.net empty to make 3 projects which is wrong selecion
  so then i  delete old ones and start with new 3 projects  with class "library" to make new

  added projects 
   Relational and Entity frameworkcore only because sql server already in.
  commit done
  again
  
  project references done
  sd.cs added



  2022/11/08
  11:02am

  using JassBookStore.Models.ViewModels; is missing in homecontroller thats why it build falied
  now running smooth
  Add > Areas> Customer   done
  path specified for controller and view ,home and moved into areas customer done
  Add > Areas> Admin   done
  upload git


 2022/11/13 11:02pm
   

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

 2022/11/14
 1:00PM
 Modified ISP_Call.cs

 Modified SP_Call.cs, 

 
 create IUnitOfWork and UnitOfWork

 2022/11/15
 1:02AM
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

not working properly i had to  add to check /Admin/Category

2022-11-21 
1132 
 i run  Command add-migration AddDefaultIdentityMigration. Succeeded. becaose create not working
 i did migration again to create




 2022-11-24
 1100


 Cover.cs amd product.css added in model 

 migration done after update failed
  add-migration addProductToDb added


  add-migration addValidationToProduct added


  2022-11-24  3:55PM
  Part 3

 done CoverType.cs 
 done CoverTypeRepository.cs 
done ICoverTypeRepository.cs 
done CoverTypeRepository to UnitOfWork
done ICoverTypeRepository to IUnitOfWork


add-migration addCoverTypeToDb
updated database 



created cover.js for the Covers table
created CoverTypeController.cs in /Areas/Admin/Controllers directory
 added Index.cshtml and Upsert.cshtml to /Areas/Admin/Views/CoverType



2022-11-27  10:30PM


add migration addProductToDb
- updated database
- added validation to Product class (Product.cs)
Added    Add migration addValidationToProduct
updated database done
 ProductRepository.cs added
- added IProductRepository interface (IProductRepository.cs)
- added ProductRepository to UnitOfWork
- added IProductRepository to IUnitOfWork



2022-12-05 10:39Pm


part 4

problem with nav bar solved with view inside jassbookstore
cover type files relaced but still error

2022-12-06 10:00Pm
forget to commit done 

2022-12-09 1:00am

Problem with cover type and display issue 
so i replaced some files with part 4 
changed files index.cshtml, upsert, product.js,cover.js

some files names issue i chnaged them

Now Everthing working great without single issue

Final commit