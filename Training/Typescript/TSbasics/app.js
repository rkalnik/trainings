console.log("Hello ExecuteAutomation");
var a = 10;
var b = "rafal";
var k = 1234522;
console.log(a, b, k);
var LanguagesKnown;
(function (LanguagesKnown) {
    LanguagesKnown[LanguagesKnown["English"] = 0] = "English";
    LanguagesKnown[LanguagesKnown["Polish"] = 1] = "Polish";
    LanguagesKnown[LanguagesKnown["German"] = 2] = "German";
})(LanguagesKnown || (LanguagesKnown = {}));
var student = {
    Name: "Rafal",
    Age: 30,
    Phone: 2334455,
    Language: LanguagesKnown[LanguagesKnown.German]
};
var studentsList = [
    { Name: "Mario", Age: 25, Phone: 5554433, Language: LanguagesKnown[LanguagesKnown.English] },
    { Name: "Ola", Age: 33, Phone: 4433222, Language: LanguagesKnown[LanguagesKnown.Polish] }
];
studentsList.push(student);
for (var index = 0; index < studentsList.length; index++) {
    var element = studentsList[index];
    console.log("Age:" + element.Age + " with Name: " + element.Name + " has Phone: " + element.Phone + " knows language: " + element.Language);
}
//# sourceMappingURL=app.js.map