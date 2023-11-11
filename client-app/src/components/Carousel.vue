<template>
 <div id="carouselId" class="carousel carousel-fade mt-5 py-4 " data-bs-ride="carousel">
    <ol class="carousel-indicators">
        <li data-bs-target="#carouselId" data-bs-slide-to="0" class="active" aria-current="true" aria-label="First slide"></li>
        <li data-bs-target="#carouselId" data-bs-slide-to="1" aria-label="Second slide"></li>
        <li data-bs-target="#carouselId" data-bs-slide-to="2" aria-label="Third slide"></li>
    </ol>
    <div class="carousel-inner" role="listbox">
        <div class="carousel-item active">
            <img src="../assets/img/logo.jpg" class="w-100 d-block" alt="First slide">
            <div class="carousel-caption d-none d-md-block">
            </div>
        </div>
        <div class="carousel-item">
            <img src="../assets/img/signIn.jpg" class="w-100 d-block img-fluid " alt="Second slide" >
            <div class="carousel-caption d-none d-md-block">
                <h3 class=" text-black text-warning-emphasis fs-5 ">Shop with us</h3>
                <p class=" text-black-50 ">Classy and Elegant fits</p>
            </div>
        </div>
        <div class="carousel-item">
            <img src="../assets/img/logo.jpg" class="w-100 d-block img-fluid h-100" alt="Third slide">
            <div class="carousel-caption d-none d-md-block">
            </div>
        </div>
    </div>
    <button class="carousel-control-prev" type="button" data-bs-target="#carouselId" data-bs-slide="prev">
        <span class="carousel-control-prev-icon" aria-hidden="true"></span>
        <span class="visually-hidden">Previous</span>
    </button>
    <button class="carousel-control-next" type="button" data-bs-target="#carouselId" data-bs-slide="next">
        <span class="carousel-control-next-icon" aria-hidden="true"></span>
        <span class="visually-hidden">Next</span>
    </button>
 </div>
</template>