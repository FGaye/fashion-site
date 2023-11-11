<script setup>
import NavBar from './components/NavBar.vue';

</script>

<template>
    <div id="app">
       <header>
 <NavBar />

         </header>
            <main>
            <router-view >

            </router-view>
            </main>
    </div>
   
</template>


