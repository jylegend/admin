// function fn(argument) {
	
// }
// fn.prototype={
// 		color:'red',
// 		say:function(){
// 			console.log("MY COLOR IS :"+this.color);
// 		}
// 	}

// var _f=new fn();
// var _c={
// 	color:'yellow'
// }
// _f.say.apply(_c)
// _f.say.call(_c)
// function Fn(){
// 	return {
// 		color:'red',
// 		say:function(){
// 			console.log("MY COLOR IS :"+this.color);
// 		}
// 	}
// }

// var _f=new Fn();
// _f.say();

// _f.say.call({color:'blue'})
// _f.say.apply({color:'blue'})

// var fn=function(a,b,c,d){
// 	console.log(a+b+c+d);
// }
// fn.call(1,2,3,4);
// fn.apply([1,2,3,4]);

// var arr1=['a','b','ddss'];

// var arr2=['111',2];

// var nArray=Array.prototype.push.apply(arr1,arr2);

// console.log(nArray);

