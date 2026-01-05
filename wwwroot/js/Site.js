window.showLoader = function (dotNetRef) {

    const loader = document.getElementById("app");
    loader.style.display = "flex";

    setTimeout(() => {
        loader.style.display = "none";

        dotNetRef.invokeMethodAsync("OnLoaderCompleted");

    }, 10000); 
};
