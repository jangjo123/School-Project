const toggleBtn = document.querySelector('.navbar_toogleBtn')
const menu_right = document.querySelector('.navbar_right')

toggleBtn.addEventListener('click', () => {
    menu_right.classList.toggle('active');
});
