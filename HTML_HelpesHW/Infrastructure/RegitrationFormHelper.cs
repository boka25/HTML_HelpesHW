using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text.Encodings.Web;

namespace HTML_HelpesHW.Infrastructure
{
    public static class RegitrationFormHelper
    {
        public static HtmlString CreateForm(this IHtmlHelper htmlHelper, string[] hobbies, string[] cources, string[] skils)
        {
            TagBuilder form = new TagBuilder("form");
            TagBuilder table = new TagBuilder("table");
            TagBuilder tr = new TagBuilder("tr");

                /*name row*/
            var tr1 = new TagBuilder("tr");
            var inputName = new TagBuilder("input");
            inputName.Attributes["type"] = "text";
            var tdName = new TagBuilder("td");
            var tdInputName = new TagBuilder("td");
            tdInputName.InnerHtml.AppendHtml(inputName);
            tdName.InnerHtml.Append("User Name");
            tr1.InnerHtml.AppendHtml(tdName);
            tr1.InnerHtml.AppendHtml(tdInputName);
            table.InnerHtml.AppendHtml(tr1);
            /**/
            /*password row*/
            var tr2 = new TagBuilder("tr");
            var inputPassword = new TagBuilder("input");
            inputName.Attributes["type"] = "password";
            var tdPass = new TagBuilder("td");
            var tdInputPass= new TagBuilder("td");
            tdInputPass.InnerHtml.AppendHtml(inputPassword);
            tdPass.InnerHtml.Append("Password");
            tr2.InnerHtml.AppendHtml(tdPass);
            tr2.InnerHtml.AppendHtml(tdInputPass);
            table.InnerHtml.AppendHtml(tr2);
            /**/
            /*gender row*/
            var tr3 = new TagBuilder("tr");

            var radioGenderMale = new TagBuilder("input");
            radioGenderMale.Attributes["type"] = "radio";
            radioGenderMale.Attributes["id"] = "male";
            radioGenderMale.Attributes["name"] = "gender";
            radioGenderMale.Attributes.Add("checked","");
            var lableMale = new TagBuilder("label");
            lableMale.Attributes["for"] = "male";
            lableMale.InnerHtml.Append("Male");

            var radioGenderFemale = new TagBuilder("input");
            radioGenderFemale.Attributes["type"] = "radio";
            radioGenderFemale.Attributes["id"] = "female";
            radioGenderFemale.Attributes["name"] = "gender";
            var lableFemale = new TagBuilder("label");
            lableFemale.Attributes["for"] = "female";
            lableFemale.InnerHtml.Append("Female");

            var tdGender = new TagBuilder("td");
            var tdInputGender = new TagBuilder("td");

            tdInputGender.InnerHtml.AppendHtml(radioGenderMale);
            tdInputGender.InnerHtml.AppendHtml(lableMale);
            tdInputGender.InnerHtml.AppendHtml(radioGenderFemale);
            tdInputGender.InnerHtml.AppendHtml(lableFemale);

            tdGender.InnerHtml.Append("Gender:");
            tr3.InnerHtml.AppendHtml(tdGender);
            tr3.InnerHtml.AppendHtml(tdInputGender);
            table.InnerHtml.AppendHtml(tr3);
            /**/

            /*address row*/
            var tr4 = new TagBuilder("tr");
            var inputAddress = new TagBuilder("textarea");

            var tdAddress = new TagBuilder("td");
            var tdInputAddress = new TagBuilder("td");
            tdInputAddress.InnerHtml.AppendHtml(inputAddress);
            tdAddress.InnerHtml.Append("Address:");
            tr4.InnerHtml.AppendHtml(tdAddress);
            tr4.InnerHtml.AppendHtml(tdInputAddress);
            table.InnerHtml.AppendHtml(tr4);
            /**/

            /*hobbies row*/
            var tr5 = new TagBuilder("tr");
            var tdHobbies = new TagBuilder("td");
            tdHobbies.InnerHtml.Append("Hobbies");

            var tdHobbiesInput = new TagBuilder("td");
            foreach (string item in hobbies)
            {
                var checkB = new TagBuilder("input");
                checkB.Attributes["type"] = "checkbox";
                checkB.Attributes["type"] = "checkbox";
                checkB.Attributes["name"] = item;
                var labelHobbies = new TagBuilder("label");
                labelHobbies.Attributes["for"] = item;
                labelHobbies.InnerHtml.AppendHtml(item);
                tdHobbiesInput.InnerHtml.AppendHtml(checkB);
                tdHobbiesInput.InnerHtml.AppendHtml(labelHobbies);

            }
            tr5.InnerHtml.AppendHtml(tdHobbies);
            tr5.InnerHtml.AppendHtml(tdHobbiesInput);
            table.InnerHtml.AppendHtml(tr5);
            /**/


            /*courses row*/
            var tr6 = new TagBuilder("tr");
            var tdCourses = new TagBuilder("td");
            tdCourses.InnerHtml.Append("Cources: ");
            tr6.InnerHtml.AppendHtml(tdCourses);
            var selectCourses = new TagBuilder("select");
            var tdCoursesInput = new TagBuilder("td");
            tdCoursesInput.InnerHtml.AppendHtml(selectCourses);
            foreach (string c in cources)
            {
                var opt = new TagBuilder("option");
                opt.InnerHtml.Append(c);
                opt.Attributes["value"] = c;
                selectCourses.InnerHtml.AppendHtml(opt);
            }
            tr6.InnerHtml.AppendHtml(tdCoursesInput);
            table.InnerHtml.AppendHtml(tr6);
            /**/


            /*skils row*/
            var tr7 = new TagBuilder("tr");
            var tdSkills = new TagBuilder("td");
            tdSkills.InnerHtml.Append("Skills: ");
            tr7.InnerHtml.AppendHtml(tdSkills);

            var divSkills = new TagBuilder("div");
            divSkills.AddCssClass("skills");
            divSkills.Attributes.Add("style", "width: 40px; height: 100px; border: 2px;");
            var tdSkillsInput = new TagBuilder("td");
            
            foreach (string s in skils)
            {
                var p = new TagBuilder("p");
                p.InnerHtml.Append(s);
                divSkills.InnerHtml.AppendHtml(p);
            }
            tdSkillsInput.InnerHtml.AppendHtml(divSkills);
            tr7.InnerHtml.AppendHtml(tdSkillsInput);
            table.InnerHtml.AppendHtml(tr7);
            /**/

            /*skils row*/
            var tr8 = new TagBuilder("tr");
            var tdButton = new TagBuilder("td");
            tdButton.InnerHtml.Append("");
            tr8.InnerHtml.AppendHtml(tdButton);
            var tdSubmit = new TagBuilder("td");
            var btnSubmit = new TagBuilder("button");
            btnSubmit.InnerHtml.AppendHtml("Send");
            btnSubmit.Attributes.Add("style", "width: 60px; height: 20px; background-color: blue; color: white; border-radius: 12px");
            tdSubmit.InnerHtml.AppendHtml(btnSubmit);

            tr8.InnerHtml.AppendHtml(tdSubmit);
            table.InnerHtml.AppendHtml(tr8);

            /**/

            table.InnerHtml.AppendHtml(tr);
            table.Attributes["border"] = "1";
            form.InnerHtml.AppendHtml(table);

            using var writer = new StringWriter();
            form.WriteTo(writer, HtmlEncoder.Default);
            return new HtmlString(writer.ToString());
        }
    }
}
