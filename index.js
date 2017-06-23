var config=require('./config.json');

import styles from './style.css';//导入

import _s from './js/sub.js';
// require('./style.css');
// document.write(config.greetText);

var app=document.createElement('div');

app.innerHTML='<h1> HAHAHHAHAHAH </h1>';

app.appendChild(_s());

document.body.appendChild(app);