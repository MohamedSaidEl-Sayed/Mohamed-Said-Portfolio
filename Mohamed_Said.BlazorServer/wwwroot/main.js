document.addEventListener('DOMContentLoaded', () => {

    /////////////////// Dark and Light Mode ////////////////////////////
    window.toggleDarkLightMode = function () {
        const modeBtn = document.getElementById('mode');
        const darkModeEle = document.getElementById('dark-mode');
        const lightModeEle = document.getElementById('light-mode');
        const htmlEle = document.documentElement;
        const localStorageMode = localStorage.getItem('mode');


        if (modeBtn && darkModeEle && lightModeEle) {
            if (localStorageMode) {
                applyMode(localStorageMode);
            } else {
                applyMode('light');
            }

            modeBtn.addEventListener('click', () => {
                if (htmlEle.classList.contains('dark')) {
                    applyMode('light');
                    localStorage.setItem('mode', 'light');
                } else {
                    applyMode('dark');
                    localStorage.setItem('mode', 'dark');
                }
            });
        }

        function applyMode(mode) {
            if (mode == 'dark') {
                htmlEle.classList.add('dark');
                darkModeEle.classList.add('hidden');
                lightModeEle.classList.remove('hidden');
            } else if (mode == 'light') {
                htmlEle.classList.remove('dark');
                darkModeEle.classList.remove('hidden');
                lightModeEle.classList.add('hidden');
            }
        }
    }


    ////////////////////////// Menu Btn ////////////////////////////
    window.toggleMenu = function () {
        const menuBtn = document.getElementById('menu-btn');
        const menuEle = document.getElementById('menu');

        if (menuBtn && menuEle) {
            menuBtn.addEventListener('click', () => {
                menuEle.classList.toggle('hidden');
            });
        }
    }


    /////////////////// Skill Category btns /////////////////////////
    window.clickSkillCategoryButton = function (btnId) {
        const button = document.getElementById(btnId);
        if (!button) return;

        button.addEventListener('click', () => {
            const skillCategoryButtons = document.querySelectorAll('.skill-category-btn');
            if (!skillCategoryButtons) return;

            skillCategoryButtons.forEach(btn => {
                btn.classList.remove('bg-brand-blue', 'text-white');
                btn.classList.add('bg-light-primary', 'dark:bg-dark-secondary', 'hover:bg-brand-blue/10');
            });

            button.classList.remove('bg-light-primary', 'dark:bg-dark-secondary', 'hover:bg-brand-blue/10');
            button.classList.add('bg-brand-blue', 'text-white');
        });
        
    }

    /////////////////// Skill Categories Slider /////////////////////////
    window.initSkillCategorySlider = function () {
        const skillCategoriesContainer = document.getElementById('skill-categoriesContainer');
        const skillCategorySlideLeft = document.getElementById('skill-category-slideLeft');
        const skillCategorySlideRight = document.getElementById('skill-category-slideRight');

        if (skillCategoriesContainer && skillCategorySlideLeft && skillCategorySlideRight) {

            skillCategorySlideLeft.addEventListener('click', () => {
                skillCategoriesContainer.scrollBy({ left: -200, behavior: 'smooth' });
            });

            skillCategorySlideRight.addEventListener('click', () => {
                skillCategoriesContainer.scrollBy({ left: 200, behavior: 'smooth' });
            });


        }
    }


    /////////////////// Course Category btns /////////////////////////
    window.clickCourseCategoryButton = function (btnId) {
        const button = document.getElementById(btnId); 
        if (!button) return;

        button.addEventListener('click', () => {
            const courseCategoryButtons = document.querySelectorAll('.course-category-btn');
            if (!courseCategoryButtons) return;

            courseCategoryButtons.forEach(btn => {
                btn.classList.remove('bg-brand-blue', 'text-white');
                btn.classList.add('bg-white', 'dark:bg-dark-primary', 'dark:text-white', 'hover:bg-brand-blue/10');
            });

            button.classList.remove('bg-white', 'dark:bg-dark-primary', 'dark:text-white', 'hover:bg-brand-blue/10');
            button.classList.add('bg-brand-blue', 'text-white');
        });
    };

    
    /////////////////// Course Categories Slider /////////////////////////
    window.initCourseCategorySlider = function () {
        const courseCategoriesContainer = document.getElementById('course-categoriesContainer');
        const courseCategorySlideLeft = document.getElementById('course-category-slideLeft');
        const courseCategorySlideRight = document.getElementById('course-category-slideRight');

        if (courseCategoriesContainer && courseCategorySlideLeft && courseCategorySlideRight) {

            courseCategorySlideLeft.addEventListener('click', () => {
                courseCategoriesContainer.scrollBy({ left: -200, behavior: 'smooth' });
            });

            courseCategorySlideRight.addEventListener('click', () => {
                courseCategoriesContainer.scrollBy({ left: 200, behavior: 'smooth' });
            });


        }
    }


    /////////////////// Back to Top Button /////////////////////////
    window.backToTop = function () {
        const backToTopBtn = document.getElementById('backToTop');

        if (backToTopBtn) {
            window.addEventListener('scroll', () => {
                if (window.scrollY >= 500) {
                    backToTopBtn.classList.remove("translate-y-20", "opacity-0", "invisible");
                    backToTopBtn.classList.add("translate-y-0", "opacity-100", "visible");
                } else {
                    backToTopBtn.classList.add("translate-y-20", "opacity-0", "invisible");
                    backToTopBtn.classList.remove("translate-y-0", "opacity-100", "visible");
                }
            });

            backToTopBtn.addEventListener('click', () => {
                window.scrollTo({ top: 0, behavior: 'smooth' });
            });
        }
    }


});

//////// Scroll to Element by ID because Blazor server interrupt href="#home" as routing to a page with url #home ////////
window.scrollToElement = function (id) {
    const el = document.getElementById(id);
    if (el) el.scrollIntoView({ behavior: 'smooth' });
}