/**
 * @param {number[]} order
 * @param {number[]} friends
 * @return {number[]}
 */
var recoverOrder = function(order, friends) {
    const friendsSet = new Set(friends);
    return order.filter(id => friendsSet.has(id));
};