export function init() {
    // simple function to use for callback in the intersection observer
    const changeNav = (entries, observer) => {
        entries.forEach((entry) => {
            // verify the element is intersecting
            if(entry.isIntersecting && entry.intersectionRatio >= 0.55) {
                // remove old active class
                document.querySelector('.active').classList.remove('active');
                // get id of the intersecting section
                var id = entry.target.getAttribute('id');
                // find matching link & add appropriate class
                var newLink = document.querySelector(`[href="#${id}"]`);
                
                newLink?.classList.add('active');
            }
        });
    }

    // init the observer
    const options = {
        threshold: 0.55
    }

    const observer = new IntersectionObserver(changeNav, options);

    // target the elements to be observed
    const sections = document.querySelectorAll('section');
    sections.forEach((section) => {
        observer.observe(section);
    });
}