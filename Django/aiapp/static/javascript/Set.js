const toggleBtn = document.querySelector('.navbar_toogleBtn')
const menu_right = document.querySelector('.navbar_right')

toggleBtn.addEventListener('click', () => {
    menu_right.classList.toggle('active');
});

document.querySelector('#ex-in').addEventListener('input',e=>{
    document.querySelector('#ex-out').innerHTML= e.target.value;
});

document.querySelector('#customRange2').addEventListener('input',e=>{
    document.querySelector('#out1').innerHTML= e.target.value;
});

document.querySelector('.form-range3').addEventListener('input',e=>{
    document.querySelector('#out2').innerHTML= e.target.value;
});

document.querySelector('.form-range4').addEventListener('input',e=>{
    document.querySelector('#out3').innerHTML= e.target.value;
});