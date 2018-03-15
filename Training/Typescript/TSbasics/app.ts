console.log("Hello ExecuteAutomation");

let a:number = 10

let b:string = "rafal";

var k: Number = 1234522
 
console.log(a, b, k)

enum LanguagesKnown { English, Polish, German }

let student = {
    Name: "Rafal",
    Age: 30,
    Phone: 2334455,
    Language: LanguagesKnown[LanguagesKnown.German]
}

let studentsList = [
    { Name: "Mario", Age: 25, Phone: 5554433, Language: LanguagesKnown[LanguagesKnown.English] },
    { Name: "Ola", Age: 33, Phone: 4433222, Language: LanguagesKnown[LanguagesKnown.Polish] }
]

studentsList.push(student);

for (let index = 0; index < studentsList.length; index++) {
    const element = studentsList[index];
    console.log("Age:" + element.Age + " with Name: " + element.Name + " has Phone: " + element.Phone + " knows language: " + element.Language);    
}

