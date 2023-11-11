<template>
    <nav class="navbar navbar-light bg-white fixed-top px-5 ">
      <div class="container-fluid">
        <h1 class="navbar-brand text-warning fw-bolder bg-white shadow  p-3 rounded-pill " href="#">Ajiphaa's Closet</h1>
        <button class="navbar-toggler" type="button" data-bs-toggle="offcanvas" data-bs-target="#offcanvasNavbar"
          aria-controls="offcanvasNavbar">
          <span class="navbar-toggler-icon"></span>
        </button>
        <div class="offcanvas offcanvas-end  bg-white " tabindex="-1" id="offcanvasNavbar"
          aria-labelledby="offcanvasNavbarLabel">
          <div class="offcanvas-header bg-warning text-white  ">
            <h5 class="offcanvas-title " id="offcanvasNavbarLabel">  Menu</h5>
            <button type="button" class="btn-close btn-warning  text-reset" data-bs-dismiss="offcanvas" aria-label="Close"></button>
          </div>
          <div class="offcanvas-body">
            <ul class="navbar-nav justify-content-end flex-grow-1 pe-3   m-2">
              <li class="nav-item">
                <button class="btn btn-outline-warning  w-100  ">
                <a class="nav-link active  " aria-current="page" href="#">Home</a>
                </button>
              </li>
              <li class="nav-item">
                <button class="btn btn-outline-warning  w-100 mt-5 ">
                <a class="nav-link active  " aria-current="page" href="#">Sign in</a>
                </button>
              </li>
              <li class="nav-item">
                <button class="btn btn-outline-warning  w-100  mt-5">
                <a class="nav-link active  " aria-current="page" href="#">Sign up</a>
                </button>
              </li>
            </ul>
          </div>
        </div>
      </div>
    </nav>
</template>