SELECT product.name, category.name
FROM product
LEFT JOIN category ON product.id_cat = category.id
GROUP BY product.name
