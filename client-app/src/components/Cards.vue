<template>
    <div class="container text-center mt-5  py-5 ">
        <div class="row mt-5 py-5">
            <h2 class=" text-capitalize mb-5">Latest</h2>
            <div class="col">
              <RouterLink to="/classic">
                <div class="card bg-light text-dark shadow">
                  <img class="card-img mt-5 py-5 " src="../assets/img/signIn.jpg" alt="Title">
                  <div class="card-img-overlay">
                    <h4 class="card-title">Classic</h4>
                    <p class="card-text">Text</p>
                  </div>
                  <button class="btn btn-warning ">see more</button>
                </div>
                </RouterLink>
            </div>
            <div class="col">
              <RouterLink to="/simple">
                <div class="card bg-light text-dark shadow ">
                  <img class="card-img mt-5 py-5" src="../assets/img/signIn.jpg" alt="Title">
                  <div class="card-img-overlay">
                    <h4 class="card-title">Simple</h4>
                    <p class="card-text">Text</p>
                  </div>
                  <button class="btn btn-warning ">see more</button>
                </div>
              </RouterLink>
            </div>
            <div class="col">
              <RouterLink to="/luxury">
                <div class="card bg-light text-black shadow" >
                  <img class="card-img mt-5 py-5" src="../assets/img/signIn.jpg" alt="Title">
                  <div class="card-img-overlay">
                    <h4 class="card-title">Luxury</h4>
                    <p class="card-text">Text</p>
                  </div>
                  <button class="btn btn-warning ">see more</button>
                </div>
              </RouterLink>
            </div>
        </div>
    </div>
</template>