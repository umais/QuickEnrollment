var myHtml = $(".mainContent").html();



//(function(){alert("Immediate Function aint that cool");}())
    
$("#cntForm").submit(function () { validateFields(); AddContent(myHtml); return false; })

function AddContent(mydata) {
    if (document.getElementById("dynamicContent") === null) {
        var contactForm = document.getElementById("contactForm");
        var newDiv = document.createElement("div");
        newDiv.setAttribute("id", "dynamicContent")
        newDiv.setAttribute("class", "scrollable");
        var textnode = document.createTextNode(mydata);
        newDiv.appendChild(textnode);
        contactForm.appendChild(newDiv);
    }
   // alert(newDiv.getAttribute("class"));
}

function validateFields()
{
    var myInputFields = document.getElementsByTagName("input");
    var totalElements = myInputFields.length;
    for (i = 0; i < totalElements; i++) {

        if (myInputFields[i].getAttribute("type") != "submit")
        {

            if (myInputFields[i].value === "")
            {

                myInputFields[i].setAttribute("class", "requiredFields");
            }
            else {

                myInputFields[i].removeAttribute("class");
            }

        }
    }




}