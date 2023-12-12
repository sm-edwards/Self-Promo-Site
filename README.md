[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-24ddc0f5d75046c5622901739e7c5dd533143b0c8e959d652212380cedb1ea36.svg)](https://classroom.github.com/a/AjZ3jSZM)
[![Open in Codespaces](https://classroom.github.com/assets/launch-codespace-7f7980b617ed060a017424585567c406b6ee15c891e84e1186181d67ecf80aa0.svg)](https://classroom.github.com/open-in-codespaces?assignment_repo_id=13184381)
# Self-Promotion Site Assignment 4

The first goal of this assignment is to migrate your SP3 assignment over to this one. You could also start from SP2 if you had trouble getting SP3 to run. If that's the case, replace `3` with `2` where appropriate in the following instructions.

## Step 0) Open the Assignment in Codespaces

Likely you're already here using Codespaces. But if by some strange set of circumstances you are not, then "Code" this repository using Codespaces.

  > NOTE: You CAN run this locally by running `git clone [repo]` and opening the resulting directory in VS Code on your local machine. Nothing special here. As long as you have .NET 7 or newer installed, it should work fine. But that's an "unsupported" option, so do so at your own risk. Okay, I'll likely still support you, but it's still slightly risky'er. 😉

## Step 1) Copy your SP3 Assignment

  > NOTE: These are essentially identical to the steps you followed in SP3, so apply any lessons learned from that assignment.

There are many ways to go about this. You just want the complete set of "non-dot" files and folders from your self-promo-FIRSTNAME directory. We'll do it the most "manual" way using downloads and drag-n-drop.

  > NOTE: I reference `FIRSTNAME` a LOT below as part of the project name, project namespace, commands, etc. __**MAKE SURE YOU REPLACE THIS WITH YOUR FIRST NAME**__!!

1) In a new tab, Navigate to your SP3 repository on the GitHub website (e.g., https://github.com/au-csci3600-23fa/self-promo-3-ptyork ... though obviously replacing your GitHub username for `ptyork`)
2) Click the [`<> Code v`] button, select the Local tab, and click Download ZIP (note the location you download the file to)
3) Return to the Codespaces tab for SP3 and ensure the "Explorer" tab is visible
4) Right-click in the Explorer pane on an empty space (e.g., directly below README.md)
5) Select "Upload..." from the context menu, locate your downloaded SP3 ZIP file, and click "Open" to upload it to Codespaces
6) In Codespaces, right-click on the `self-promo-3-USERNAME-main.zip` FILE you just uploaded and select "Mount Zip"
    * This will cause your Codespace to refresh...don't panic)
    * You should now have a `self-promo-3-USERNAME-main.zip` FOLDER expanded showing the contents of your SP3 submission
    * NOTE: this feature is part of a ZipFS extension, so you won't see it if you do this locally
7) Right-click on the `self-promo-FIRSTNAME` project folder from the "mounted" zip folder and `Copy` it
8) Right-click on the root `self-promo-4-USERNAME` folder at the top of the explorer window and `Paste` your project folder there
9) Right click on the mounted zip FOLDER and Unmount it
10) Right click on the zip FILE and Delete it

9 & 10 aren't strictly necessary, but I recommend it to avoid accidentally modifying the contents of your old project, which I won't be grading and will just be confusing.

Now let's just make sure everything worked.

1) In the Terminal window, change to your project directory (`cd self-promo-FIRSTNAME`)
2) Run your project (`dotnet watch`)
3) Check the output
    * Switch from "Terminal" to "Ports" tab
    * Find the 5xxx port (Five-Thousand and _something_)
    * Hover over forwarded address URL and click the globe

With luck, all is well. If not, double and then triple check the above directions. If you're pretty sure your doing everything as instructed and still having issues, then reach out via the Assignment Questions channel in Teams.

## Step 2) Insure Your Layout is Script-Ready

If you fully followed SP3, this step should be just a confirmation step. If not, then we need to get your `_Layout.cshtml` file up to snuff.

Open `_Layout.cshtml` from the `Pages/Shared` folder. At the bottom of the `<head>` section, check to insure that you have the jQuery script and the "Head" section rendered as follows:

```
  <script src="~/lib/jquery/dist/jquery.min.js"></script> 
  @RenderSection("Head", false)
```

Also, scroll to the bottom and insure that you have a "Scripts" section immediately above your `</body>`, as shown below.

```
  @RenderSection("Scripts", false)
```

That's it. The nice thing about JavaScript is that it's mostly just "built in" to the browsers. Unless you're downloading and importing additional scripts or libraries (like jQuery, there), there's really nothing to do to prep your project to support JavaScript.


## Step 3) Add a Contact Me Page

Remember back in SP2 when you had to "translate" a couple of Selfie-Site instructions to add pages to your ASP.NET site? Yeah, we're doing that one more time. And again it's TWO whole assignments!!!

But don't panic, as these are really just one pretty simple assignment split into two. We'll just be adding a single Contact Me page that has a table of contact methods and a contact form.

So:

  1. Add a `Contact.cshtml` page (and optionally a `Contact.cshtml.cs` file) to your `Pages` directory. Perhaps copy `Index.cshtml` to make this easier? We're not going to be doing any server-side stuff here, so if you want to leave off the CS PageModel, you can. Be sure to remove the `@model`` directive at the top of the page if you do. Just make sure you're left with a blank slate in terms of the HTML part of this file.

  2. Add a navigation link ("Contact Me") to this new page in your `Shared/_Layout.cshtml` file.

  3. Add the Contact Me heading and table as specified in the SS9 instructions provided in this project directory. Make the required CSS changes to `/wwwroot/styles/selfie.css`.

      > NOTE: I do NOT care about your contact methods. Just make some up if you don't have any or don't want to share. "Pony Express" and "Super-Spy Shoe Phone" are equally fine. Maybe even better. I won't be clicking on any of the links. Just make sure you have the requisite number of rows.

  4. Ditto #3 for the contact form from SS10. It doesn't REALLY matter whether you set the form to post or send it to the provided URL. We're going to override this soon. However, it may be useful for you to test your form. So I guess follow the instructions. Though feel free to come up with humorous purposes for the drop-down list.

Test things now if you haven't just to make sure you can see the contact page, submit the form, etc.

## Step 4) Make the Contact Information and Feedback Form "Collapsible"

  > NOTE: I'll be making the rest of these instructions purposely require "interpretation." I want you NOT to just be copy/paste factories, and I want you to have to watch and comprehend the lectures to complete these. So you'll have enough information to succeed if you've followed along in the lectures.

The idea here is simply to use JavaScript (or jQuery) and CSS to make the table or form "disappear" if you click on the heading. This is super-simple if you download a jQuery plugin, but we're not about super-simple. We're about learning by doing.

Start by making things "look" clickable. This is an important aspect of adding interactivity. User's ain't gonna click if they don't perceive something as being clickable. One of them there HCI principles, I hear...

Add a few CSS rules to your CSS file. This I *WILL* give you since they're a bit...special:

```
.collapsible {
    cursor: pointer;
}
.collapsible:before {
    content: '\25BC';
    margin-right: .5em;
}
.collapsible.closed:before {
    content: '\25BA';
}
```

The idea is that you'll be adding a class of `collapsible` to your `<h3>` elements. These CSS rules will add an arrow to the left of the heading and make it so that the mouse cursor gives the heading the finger when it hovers over it.

Adding and removing a second `closed` class to your `<h3>` element (i.e., `class="collapsible closed"`) should toggle this arrow right or down. Test this, but leave it off when you're done...just make it collapsible.

Note the `:before` psuedo-selector. This selects the (usually empty and zero-width) area BEFORE the element. The `content` declaration allows you to place content in this area.

The `\25BC` and `\25BA` the hexadecimal number representing a Unicode text character. These two happen to be right and down arrows. They're kinda ugly and boring, so have fun playing with them. https://www.toptal.com/designers/htmlarrows/arrows/

In other words, you need to pick symbols OTHER than the ones I gave you in the CSS above. That's me trying to make sure you read the instructions and don't just copy/paste if you're not following my sneaky pedagogical logic here.

At the bottom of your page, add a @scripts section as demonstrated in lecture. Add a `<script>` element and start your first JavaScript coding.

  > NOTE: For this and all JS code, you may leverage vanilla JavaScript, jQuery, or any combination of the two.

  > BIG, HUGE, MONGO NOTE: DO NOT FORGET ABOUT CHECKING THE DEVELOPER TOOLS CONSOLE OUTPUT!!! `Ctrl + Shift + I`` or right-click and inspect to show it. LOOK FOR ERRORS HERE!!!!!! JAVASCRIPT USUALLY FAILS **__SILENTLY__** IN THE BROWSER!!

Your goal is to add a 'click' event listener to ALL elements with a class of `collapsible` (there will be two since you're adding it to BOTH of your `<h3>` elements). The listener method should either show or hide the element AFTER the one you are clicking (hints on how to do this two different ways are in the final feedback form lecture about UI magic) AND either add or remove the `closed` class from the `<h3>` itself.

  > HINT: Remember that `this` inside of an event listener method refers to the element that is triggering the event (i.e. the `<h3>` in this case). So `this.nextSibling` in 'vanilla' and `$(this).next()` in jQuery should give you access to the element after the `.collapsible` element...i.e., the `<table>` or `<form>` that needs to be hidden.

  > HINT 2: The `classList` property of an element has a `toggle()` method. Likewise, jQuery elements have a `toggleClass()` method. These may prove useful and thus you may wish to look them up.

In the end, you should have the ability to click on each of the two headings to toggle the table or form to be shown or hidden. Adding animation to beautify this is optional but encouraged.

  > NOTE: Though it's definitely not needed for this, if you want to style the "next" element in CSS, you could use a sibling selector. I.e., "`.collapsible + *`" and "`.collapsible.closed + *`" COULD be used to select the elements following your `.collapsible` ones. Mostly just FYI...

## Step 5) Submit the Contact Form using AJAX

Here we want to take the user feedback and submit it to the server using AJAX instead of the normal form submission method. Don't worry, though. I just want it to get to the server. No need to actually store it or retrieve it or anything. At least not outside of extra-credit.

You'll definitely need to have watched the lecture and _reference_ (i.e., not copy/paste as it's not the same) the sample code for this.

First tackle the JavaScript side of things.

  1) Create an event listener that intercepts the form submit event.
  
  2) Cancel the form submission by "preventing the default".

  3) "Bundle up" the form fields into a single JavaScript object using whatever method you find most appealing (i.e., manually as demonstrated or using the FormData shortcut).

  4) Convert the object to JSON syntax and POST it to `/api/contact` using the fetch API (don't forget the await).

  5) Use good error handling practices and check the response to see if it was OK. If so, just "alert" something like "Thank you for your feedback." and clear the form. Otherwise, alert something like "An error occurred. Please try again."

Trying this now SHOULD give you the error message since there's no Controller. Let's fix that.

## Step 6) Receive the Contact Information Using a Web API

You need to modify your project to support API Controllers now. You'll likely need to Ctrl+C your dotnet watch at this point since we're mucking around in the plumbing.

Modify `Program.cs` as shown in the lecture to add Controllers and controller route mapping.

Add a `/Controllers` directory (remember this is in the root of the project alongside `/Pages` and `/wwwroot`).

Add a `ContactController.cs` file and use the example code from the lecture to set up the `usings` and the basic class structure. You'll want it to be in the `self_promo_FIRSTNAME.api` namespace. Don't forget the ApiController and Route decorations.

  > NOTE: You don't actually need your DbContext or even the logger. Which means you don't even need the constructor, since there's no dependency injection or any other logic to run on object creation.  So if you want you can ONLY have a single method (below) in the class. But it won't hurt to have the constructor.

No need for a GET method. ONLY a POST method. Mostly the goal is just to say "OK, all is well", but I want you to print the content of the request body which isn't trivial. Because it could be HUGE and/or contain binary content, the request body isn't just a string. It's a "stream". And you need a stream reader to read it into a string. Anyway, I'll give you this little bit of copy/paste code.

```
    [HttpPost]
    public async Task<ActionResult> PostContactAsync()
    {
        var reader = new StreamReader( Request.Body );
        Console.WriteLine( await reader.ReadToEndAsync() );
        return Ok();
    }
```

  > NOTE: Even though you will be passing JSON to in the body of your POST, you don't HAVE to have the parameter to "accept" this. A "parameterless" HttpPost method like this is basically a "fallthrough" or "catchall" that will accept ANY post regardless of whether it has a JSON body that is "shaped" like a specific C# class. Which is good, because we don't actually HAVE a C# class that looks like the JSON we constructed. Pretty standard method overloading stuff (I think I may have accidentally said "polymorphism" in lecture...this is method "overloading").

If you did all correctly, you should at this point be able to run the application, submit the contact form, and receive the successful "Thank you" message in your script. Be sure to check that your contact form JSON is being printed in the server terminal output. I will. ;)

## Step 7) Populate your Gallery using AJAX

  > NOTE: If you didn't get SP3 working and don't have access to a Gallery page, you can try to redo at least that part so you have a working Gallery. Otherwise, you'll just lose out on these points.

This last one should actually be quite easy if you've made it this far. Your goal is to load the photos for your Gallery page using AJAX and a static JSON file. Sure, ideally this would be JSON generated from the database, and you'd have an admin page to add and remove photos, but that's very non-trivial. So, we'll just "cheat" and go the static file route.

Assuming your photo gallery images are where they were supposed to be (`/wwwroot/images/photos`), create a `/wwwroot/images/photos/gallery.json` file. If they photos aren't there, well, put the json file wherever your photos are.

The content of this file should just be an array of objects that looks something like this:

```
[
    {
        "image" : "happyme.jpg",
        "thumb" : "happyme_thumb.jpg",
        "caption" : "Me looking very, very happy"
    },
    ...
]
```

  > NOTE: JSON is very picky about array elements and commas and such. Make sure that the objects and properties all have commas in BETWEEN then, but DO NOT have trailing commas at the end of the list of properties or after the last item/object in an array. You can get a lot of weird errors when calling `json()` on the response that can be related to this.

Use the photos currently in your `Gallery.cshtml` to populate this. In the end it should have an object in the array for each of the photos in your gallery.

Not, on your `Gallery.cshtml` page, you are going to delete all of your figures. In fact, if you did everything right in SP3, the entire content of your page should be empty. Regardless, the figures should be removed. Whatever element you have that has `class="gallery"` should NOT be removed, but should be empty.

Now at the bottom, add an `@section Scripts` and put in a `<script>` element to start writing your JavaScript.

Create an async function called `loadGallery`. This function will resemble the examples from lecture (either the simpler dogs AJAX example or the one for the feedback form).

  * Fetch `/images/photos/gallery.json`. Obviously change this to reflect reality if you're stuff ain't where I'd initially intended it to be. REMEMBER that the `/wwwroot`` is removed from the URL's.
  * You will read the body as json into an object (this will be an array of objects...just like the dogs and the contacts...notice a common pattern here?).
  * You will use a for/of loop to iterate over each of the photo objects. For each of them, you'll be adding a new figure element. I suggest the following:
    * Use the document object's createElement method to create a figure element.
    * Use string interpolation to create a BASH (big ass string of HTML) containing the `<a>` and the `<img>` and the `<figcaption>`.
    * Set your figure element's innerHTML to the BASH.
    * Append the figure element as a child of the element with the `.gallery` selector.
  
  > NOTE: As always, a healthy comprehension of the lectures will really help with the above, especially regarding creating and appending elements. As a hint, that kind of logic is covered in the JS in the browser lecture, with sample code in JS Playground's js_dom.html file. It's the "cheat" way, because doing it the "right" way is quite onerous with so many elements and attributes. Though I encourage you to try your hand at the "right" way (using createElement and innerText ONLY...no innerHTML).

  > NOTE 2: I'll leave it to you to figure out how to get the `src` and `href` right, but REMEMBER that "~" does NOT work here. Your URL's should all start with absolute paths to `/images/`, and we'll just ignore potential future issues with non-root hosting.

Lastly, you'll need to CALL this function. I.e., the last line of your script should just be `loadGallery();`

 As I noted in the lecture, we have to do this because we can't "await" something in the main body of our script, only in async functions.

  > DISCLAIMER: As with so many things, this is not precisely true and there are ways around this using "fluent Promise" syntax. But there's a limit to how much your brain can be fed at this point.

The end result is a page that will (again) look identical to the Gallery page before you touched it. It'll just be cooler in a mostly pointless kind of way.


## STEP 9 ¾) Optional Challenge Exercises

If you take on any of these, make sure you let me know in the submission comment on D2L so that I know to look for them.

  1) (2 pts+) For the first person to file a unique "bug report" on these instructions. Not something silly or just a tiny typo (unless it causes things to break and the fix isn't obvious), but a missing or incorrect step, something described incorrectly, etc.
  
  2) (5 pts) Alert messages are terrible. In step 5, if things succeed then remove the form (not hide or toggle...actually remove() it from the DOM) and add a new `<h4>` saying thank you for the feedback. Alert is still fine for the error message.
  
  3) (10 pts) It would be great to actually store the contact information in a table. So you can follow my lecture and basically do the same thing I did (just for the POST, not forGET the GET part) to create an appropriate model object, add it to the data context, and then store the data in your database. Assume you'll just use the SQLite viewer to view the feedback, so no need for a page to view the feedback...
  
  4) (5 pts) ...but you COULD add another admin page that simply VIEWS the contacts (ordered most recent to oldest). Not full CRUD, so no scaffolding. Just a page that shows the contacts (similar to but much simpler than your Experience page).

## Step The One Where You're Done) Test and Submit

When you are done, make sure you've tested it. Then click on the Source Control tab, **enter a commit message**, and Commit & Sync this to GitHub.

Don't forget to double check that the code is all there by either clicking on the GitHub classroom link again and opening the repository from there or by going directly to the repository at https://www.github.com/au-csci3600-23fa/self-promo-4-YOURID/
