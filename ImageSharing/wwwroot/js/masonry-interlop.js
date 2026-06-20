window.initMasonry = (containerElement) => {
    // 1. Inicjalizacja biblioteki imagesLoaded
    imagesLoaded(containerElement, function () {
        // 2. Ta funkcja wywoła się, gdy wszystkie obrazki się pobiorą
        new Masonry(containerElement, {
            itemSelector: '.masonry-item',
            columnWidth: '.masonry-sizer',
            gutter: 20,
            fitWidth: true,
        });
    });
};