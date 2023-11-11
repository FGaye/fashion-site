
<template>
  <div class="container text-center justify-content-center  p-2">
    <div class="row justify-content-center p-3 m-auto  shadow-lg rounded-5  w-75">
      <div class="col">
        <img src="../assets/img/signup.jpg" alt="" class="img-fluid h-100 rounded-2">
      </div>

      <div class="col">
        <h1>Sign Up</h1>
        <form action="" class="form-inline m-2 py-5" role="form" @submit.prevent="signUp">
          <div class="row mb-4">
            <label for="inputUserName" class="col-sm-2 col-form-label p-1">Name </label>
            <div class="col-sm-10">
              <input type="text" class="form-control" id="inputUserName" v-model="formData.userName">
            </div>
          </div>
          <div class="row mb-4">
            <label for="inputEmail3" class="col-sm-2 col-form-label ">Email</label>
            <div class="col-sm-10">
              <input type="email" class="form-control" id="inputEmail3" v-model="formData.emailAddress"/>
            </div>
          </div>
          <div class="row mb-4">
            <label for="inputPassword3" class="col-sm-2 col-form-label p-1">Password </label>
            <div class="col-sm-10">
              <input type="password" class="form-control" id="inputPassword3" v-model="formData.password">
            </div>
          </div>
          <div class="row m-0 ">
          <button type="submit" value="Sign Up" class="btn btn-secondary m-1" @submit="signUp">Sign Up</button>
          </div>
        </form>
        <div class="form-text">Already have an account?</div>
        <RouterLink to="/login">
          <div class="row m-0 ">
          <button type="submit" value="Sign In" class="btn btn-secondary m-1">Sign In</button>
          </div>
        </RouterLink>
      </div>
    </div>
  </div>
</template>

<script setup>
import { ref } from "vue";
import axios from "axios";

  const formData = ref({
    userName: '',
    emailAddress: '',
    password: ''
  })
 async function signUp(event)
{
  event.preventDefault();
  
  try{
  const response = await axios.post("http://localhost:5272/Account/register",formData.value);
  console.log(response.data)
  }catch(error)
    {console.log(error);
  }
  
}

</script>
