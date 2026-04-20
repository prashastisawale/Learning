let a = '12345678as';
let sum = 0;
for (let i = 0; i<a.length; i++){
    if(!isNaN(a[i])){
        sum += parseInt(a[i]);
        
    }
}
console.log("Sum of digits: " + sum);