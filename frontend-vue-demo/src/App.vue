<template>
  <div class="container">
    <h1>Richard's Portfolio - Frontend Demo</h1>
    <ProductList />
  </div>
</template>

<script setup lang="ts">
import ProductList from './components/ProductList.vue';
</script>

<style>
body { font-family: Arial, sans-serif; margin: 20px; }
.container { max-width: 900px; margin: 0 auto; }
</style>
