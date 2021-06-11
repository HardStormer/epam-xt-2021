/* 7.1 CHAR REMOVER */
console.log("7.1 CHAR REMOVER");

var str = "У попа была собака";
var ignore = ["?", "!", ":", ";", ",", ".", " ", "\t", "\r"];
var letters = {}, result;
var words = str.split(' ');
console.log("Введена строка: " + str);
 
words.forEach(function (word) {
    word.split('').forEach(function (letter, i) {
        if (!letters[letter] && ignore.indexOf(letter) == -1 && -1 != word.indexOf(letter, i + 1)) {
            letters[letter] = 1;
        }
    });
});
 
result = str.split('').filter(function (v) {
    return !letters[v];
}).join('');

console.log(result); 


/* 7.2 MATH CALCULATOR */
console.log("7.2 MATH CALCULATOR");


function func(str){
	const mass = [];
	const operators = ['+', '-', '*', '/', '='];
	var arr =  str.replace('=','').split(/[\+\-\*\/\=]/).map(Number);
	str.split('').forEach(element => {
		if(operators.indexOf(element) != -1){
			mass.push(element);
		}
	});
	
	var result = arr[0];
	
	mass.forEach((word,i)=>{
		if(word == "+"){
			result += arr[i+1];
		}
		else if(word == "-"){
			result -= arr[i+1];
		}
		else if(word == "*"){
			result *= arr[i+1];
		}
		else if(word == "/"){
			result /= arr[i+1];
		}
	})
	return result.toFixed(2);
}
console.log("Введена строка: 3.5 +4*10-5.3 /5 =");
console.log(func("3.5 +4*10-5.3 /5 ="));


/* 7.3 MINI CRUD  */
console.log("7.3 MINI CRUD");


class Service{
    constructor(){
        this.mass = [];
        this.keyValues = 0;
    }

    add(value) {
         this.mass[this.keyValues] = value;    
         this.keyValues++; 
    }

    getById(id){
        if(!this.mass[id] == null){
            return null
        }
        else{
            return this.mass[id]
        }
    }

    getAll = () => this.mass

    deleteById(id){
        var element = this.mass[id]
        delete this.mass[id]
        return element
    }

    updateById(id , value){
        for(var key of Object.keys(value)){
            this.mass[id][key] = value[key];
        }
    }

    replaceById(id , value){
        this.mass[id] = value
    }
}


var storage = new Service();

const First = { данные : "первые данные" }

const Second = { данные : "вторые данные" }

const NewFirst = { данные : "данные изменились" }

console.log("Добавили первые данные");
storage.add(First);

console.log("Добавили вторые данные");
storage.add(Second);

console.log("Ищем по ID 1");
console.log(storage.getById(1));

console.log("Удаляем ID 1")
storage.deleteById(1)


console.log("Обновляем ID 0");
storage.updateById(0, NewFirst)

console.log("Заменяем ID 1 на First");
storage.replaceById(1, First)

console.log(storage.getAll())