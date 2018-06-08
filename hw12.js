class Report {
constructor(student,grade){
    this._student=student;
    this._grade=grade;
    this._score=86;
}
get student(){
return this._student;
}
get grade(){
    return this._grade;

}
test1(num){
this._grade -= num;
console.log(`you failed the test and your grade went down to ${this._grade}`)
}
extracredit() {
    this._score += 15;
    console.log(`you did extra work your new score is ${this._score}`);
}

}

class teacherName extends Report {
    constructor (student,grade,teacher) {
    super(student,grade);
    this._teacher=teacher;  
}
get teacher () {
    return this._teacher;
   
}

}
var reportCard = new teacherName("Jon",78,"Professor X");
console.log (reportCard.student);
console.log(reportCard.grade);
console.log(reportCard.teacher);
console.log(`Dear ${reportCard.student}`);
reportCard.extracredit();
reportCard.test1(7);
console.log(`sincerly ${reportCard.teacher}`);

