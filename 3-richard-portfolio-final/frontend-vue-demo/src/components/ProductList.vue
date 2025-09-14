<template>
  <div>
    <h2>Products</h2>
    <div v-if="loading">Loading...</div>
    <ul v-else-if="products.length">
      <li v-for="p in products" :key="p.id">
        <strong>{{ p.name }}</strong> - {{ formatCurrency(p.price) }}
      </li>
    </ul>
    <p v-else>No products</p>
  </div>
</template>

<script setup lang="ts">
import { ref, onMounted } from 'vue';
import axios from 'axios';

const products = ref<Array<any>>([]);
const loading = ref(true);

onMounted(async () => {
  try {
    const res = await axios.get(import.meta.env.VITE_API_URL + '/api/products');
    products.value = res.data;
  } catch (e) {
    console.error('Failed to load products', e);
  } finally {
    loading.value = false;
  }
});

function formatCurrency(val: number) {
  return new Intl.NumberFormat('en-US', { style: 'currency', currency: 'USD' }).format(val);
}
</script>
