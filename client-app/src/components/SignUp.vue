<script setup>
import { ref } from 'vue'


const count = ref(0)
</script>

<template>
  <div class="container text-center justify-content-center  p-2">
    <div class="row justify-content-center p-3 m-auto  shadow-lg rounded-5  w-75">
      <div class="col">
        <img src="../assets/img/signup.jpg" alt="" class="img-fluid h-100 rounded-2">
      </div>

      <div class="col">
        <h1>Sign Up</h1>
        <form action="" class="form-inline m-2 py-5" role="form">
          <div class="row mb-4">
            <label for="inputEmail3" class="col-sm-2 col-form-label ">Email</label>
            <div class="col-sm-10">
              <input type="email" class="form-control" id="inputEmail3">
            </div>
          </div>
          <div class="row mb-4">
            <label for="inputPassword3" class="col-sm-2 col-form-label p-1">Password </label>
            <div class="col-sm-10">
              <input type="password" class="form-control" id="inputPassword3">
            </div>
          </div>
          <div class="row m-0 ">
          <button type="submit" value="Sign Up" class="btn btn-secondary m-1">Sign Up</button>
          </div>
        </form>
        <div class="form-text">Do not have an account?</div>
        <div class="row m-0 ">
          <button type="submit" value="Sign In" class="btn btn-secondary m-1">Sign In</button>
          </div>
      </div>
    </div>
  </div>
</template>


